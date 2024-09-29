using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Threading;
using MonkeModManager.Internals;
using System.Diagnostics;
using System.Runtime.InteropServices;
using MonkeModManager.Internals.SimpleJSON;
using System.Text.RegularExpressions;

namespace MonkeModManager
{
    public partial class FormMain : Form
    {

        private const string BaseEndpoint = "https://api.github.com/repos/";
        private const Int16 CurrentVersion = 6;
        private List<ReleaseInfo> releases;
        Dictionary<string, int> groups = new Dictionary<string, int>();
        private string InstallDirectory = @"";
        private bool modsDisabled = false;
        public bool isSteam = true;
        public bool platformDetected = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           

        #region ReleaseHandling

      
        }

        private void LoadRequiredPlugins()
        {
          
        }

        private void UpdateReleaseInfo(ref ReleaseInfo release)
        {
            Thread.Sleep(100); //So we don't get rate limited by github

            string releaseFormatted = BaseEndpoint + release.GitPath + "/releases";
          
            
            
          
        }

        #endregion // ReleaseHandling

        #region Installation

        private void Install()
        {
            ChangeInstallButtonState(false);
            UpdateStatus("Starting install sequence...");
            foreach (ReleaseInfo release in releases)
            {
                if (release.Install)
                {
                    UpdateStatus(string.Format("Downloading...{0}", release.Name));
                    byte[] file = DownloadFile(release.Link);
                    UpdateStatus(string.Format("Installing...{0}", release.Name));
                    string fileName = Path.GetFileName(release.Link);
                    if (Path.GetExtension(fileName).Equals(".dll"))
                    {
                        string dir;
                        if (release.InstallLocation == null)
                        {
                            dir = Path.Combine(InstallDirectory, @"BepInEx\plugins", Regex.Replace(release.Name, @"\s+", string.Empty));
                            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                        }
                        else
                        {
                            dir = Path.Combine(InstallDirectory, release.InstallLocation);
                        }
                        File.WriteAllBytes(Path.Combine(dir, fileName), file);

                        var dllFile = Path.Combine(InstallDirectory, @"BepInEx\plugins", fileName);
                        if (File.Exists(dllFile))
                        {
                            File.Delete(dllFile);
                        }
                    }
                    else
                    {
                        UnzipFile(file, (release.InstallLocation != null) ? Path.Combine(InstallDirectory, release.InstallLocation) : InstallDirectory);
                    }
                    UpdateStatus(string.Format("Installed {0}!", release.Name));
                }
            }
            UpdateStatus("Install complete!");
            ChangeInstallButtonState(true);

            this.Invoke((MethodInvoker)(() =>
            { //Invoke so we can call from any thread
               
            }));
        }

        #endregion // Installation

        #region UIEvents

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Install();
            }).Start();
        }

        private void buttonFolderBrowser_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.FileName = "Gorilla Tag.exe";
                fileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
                fileDialog.FilterIndex = 1;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = fileDialog.FileName;
                    if (Path.GetFileName(path).Equals("Gorilla Tag.exe"))
                    {
                        InstallDirectory = Path.GetDirectoryName(path);
                        textBoxDirectory.Text = InstallDirectory;
                    }
                    else
                    {
                        MessageBox.Show("That's not Gorilla Tag.exe! please try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

       
                          

         

        private void buttonUninstallAll_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "You are about to delete all your mods (including hats and materials). This cannot be undone!\n\nAre you sure you wish to continue?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                UpdateStatus("Uninstalling all mods");

                var pluginsPath = Path.Combine(InstallDirectory, @"BepInEx\plugins");

                try
                {
                    foreach (var d in Directory.GetDirectories(pluginsPath))
                    {
                        Directory.Delete(d, true);
                    }

                    foreach (var f in Directory.GetFiles(pluginsPath))
                    {
                        File.Delete(f);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UpdateStatus("Failed to uninstall mods.");
                    return;
                }

                UpdateStatus("All mods uninstalled successfully!");
            }
        }

        private void buttonBackupMods_Click(object sender, EventArgs e)
        {
            var pluginsPath = Path.Combine(InstallDirectory, @"BepInEx\plugins");

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = InstallDirectory,
                FileName = $"Mod Backup",
                Filter = "ZIP Folder (.zip)|*.zip",
                Title = "Save Mod Backup"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
            {
                UpdateStatus("Backing up mods...");
                try
                {
                    if (File.Exists(saveFileDialog.FileName)) File.Delete(saveFileDialog.FileName);
                    ZipFile.CreateFromDirectory(pluginsPath, saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UpdateStatus("Failed to back up mods.");
                    return;
                }
                UpdateStatus("Successfully backed up mods!");
            }


        }

        private void buttonBackupCosmetics_Click(object sender, EventArgs e)
        {
            var pluginsPath = Path.Combine(InstallDirectory, @"BepInEx\plugins");

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = InstallDirectory,
                FileName = $"Cosmetics Backup",
                Filter = "ZIP Folder (.zip)|*.zip",
                Title = "Save Cosmetics Backup"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
            {
                UpdateStatus("Backing up cosmetics...");
                if (File.Exists(saveFileDialog.FileName)) File.Delete(saveFileDialog.FileName);
                try
                {
                    ZipFile.CreateFromDirectory(Path.Combine(pluginsPath, @"GorillaCosmetics\Hats"), saveFileDialog.FileName, CompressionLevel.Optimal, true);
                    using (ZipArchive archive = ZipFile.Open(saveFileDialog.FileName, ZipArchiveMode.Update))
                    {
                        foreach (var f in Directory.GetFiles(Path.Combine(pluginsPath, @"GorillaCosmetics\Materials")))
                        {
                            archive.CreateEntryFromFile(f, $"{Path.Combine("Materials", Path.GetFileName(f))}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UpdateStatus("Failed to restore cosmetics.");
                    return;
                }
                UpdateStatus("Backed up cosmetics!");
            }
        }

        private void buttonRestoreMods_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = InstallDirectory;
                fileDialog.FileName = "Mod Backup.zip";
                fileDialog.Filter = "ZIP Folder (.zip)|*.zip";
                fileDialog.FilterIndex = 1;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!Path.GetExtension(fileDialog.FileName).Equals(".zip", StringComparison.InvariantCultureIgnoreCase))
                    {
                        MessageBox.Show("Invalid file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UpdateStatus("Failed to restore mods.");
                        return;
                    }
                    var pluginsPath = Path.Combine(InstallDirectory, @"BepInEx\plugins");
                    try
                    {
                        UpdateStatus("Restoring mods...");
                        using (var archive = ZipFile.OpenRead(fileDialog.FileName))
                        {
                            foreach (var entry in archive.Entries)
                            {
                                var directory = Path.Combine(InstallDirectory, @"BepInEx\plugins", Path.GetDirectoryName(entry.FullName));
                                if (!Directory.Exists(directory))
                                {
                                    Directory.CreateDirectory(directory);
                                }

                                entry.ExtractToFile(Path.Combine(pluginsPath, entry.FullName), true);
                            }
                        }
                        UpdateStatus("Successfully restored mods!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UpdateStatus("Failed to restore mods.");
                    }
                }
            }
        }

        private void buttonRestoreCosmetics_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = InstallDirectory;
                fileDialog.FileName = "Cosmetics Backup.zip";
                fileDialog.Filter = "ZIP Folder (.zip)|*.zip";
                fileDialog.FilterIndex = 1;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!Path.GetExtension(fileDialog.FileName).Equals(".zip", StringComparison.InvariantCultureIgnoreCase))
                    {
                        MessageBox.Show("Invalid file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UpdateStatus("Failed to restore co0smetics.");
                        return;
                    }
                    var cosmeticsPath = Path.Combine(InstallDirectory, @"BepInEx\plugins\GorillaCosmetics");
                    try
                    {
                        UpdateStatus("Restoring cosmetics...");
                        using (var archive = ZipFile.OpenRead(fileDialog.FileName))
                        {
                            foreach (var entry in archive.Entries)
                            {
                                var directory = Path.Combine(InstallDirectory, @"BepInEx\plugins\GorillaCosmetics", Path.GetDirectoryName(entry.FullName));
                                if (!Directory.Exists(directory))
                                {
                                    Directory.CreateDirectory(directory);
                                }

                                entry.ExtractToFile(Path.Combine(cosmeticsPath, entry.FullName), true);
                            }
                        }
                        UpdateStatus("Successfully restored cosmetics!");
                    }
                    catch
                    {
                        MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UpdateStatus("Failed to restore cosmetics.");
                    }
                }
            }
        }

        #region Folders

        private void buttonOpenGameFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(InstallDirectory))
                Process.Start(InstallDirectory);
        }

        private void buttonOpenConfigFolder_Click(object sender, EventArgs e)
        {
            var configDirectory = Path.Combine(InstallDirectory, @"BepInEx\config");
            if (Directory.Exists(configDirectory))
                Process.Start(configDirectory);
        }

        private void buttonOpenBepInExFolder_Click(object sender, EventArgs e)
        {
            var BepInExDirectory = Path.Combine(InstallDirectory, "BepInEx");
            if (Directory.Exists(BepInExDirectory))
                Process.Start(BepInExDirectory);
        }

        #endregion // Folders

        private void buttonOpenWiki_Click(object sender, EventArgs e)
        {
            Process.Start("https://gorillatagmodding.burrito.software/");
        }

        private void buttonDiscordLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/ux4ZbBC6JQ");
        }

        #endregion // UIEvents

        #region Helpers

        private CookieContainer PermCookie;
        

        private void UnzipFile(byte[] data, string directory)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                using (var unzip = new Unzip(ms))
                {
                    unzip.ExtractToDirectory(directory);
                }
            }
        }

        private byte[] DownloadFile(string url)
        {
            WebClient client = new WebClient();
            client.Proxy = null;
            return client.DownloadData(url);
        }

        private void UpdateStatus(string status)
        {
            string formattedText = string.Format("Status: {0}", status);
            this.Invoke((MethodInvoker)(() =>
            { //Invoke so we can call from any thread
             
            }));
        }
  
        private void NotFoundHandler()
        {
            bool found = false;
            while (found == false)
            {
                using (var fileDialog = new OpenFileDialog())
                {
                    fileDialog.FileName = "Gorilla Tag.exe";
                    fileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
                    fileDialog.FilterIndex = 1;
                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = fileDialog.FileName;
                        if (Path.GetFileName(path).Equals("Gorilla Tag.exe"))
                        {
                            InstallDirectory = Path.GetDirectoryName(path);
                            textBoxDirectory.Text = InstallDirectory;
                            found = true;
                        }
                        else
                        {
                            MessageBox.Show("That's not Gorilla Tag.exe! please try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                }
            }
        }

        private void CheckVersion()
        {
            UpdateStatus("Checking for updates...");
            
           
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("Your version of the mod installer is outdated! Please download the new one!", "Update available!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Process.Start("https://github.com/DeadlyKitten/MonkeModManager/releases/latest");
                    Process.GetCurrentProcess().Kill();
                    Environment.Exit(0);
                }));
            }
        }

        private void ChangeInstallButtonState(bool enabled)
        {
            this.Invoke((MethodInvoker)(() =>
                {
               
                }));
        }

       

#endregion // Helpers

#region Registry

        private void LocationHandler()
        {
            string steam = GetSteamLocation();
            if (steam != null)
            {
                if (Directory.Exists(steam))
                {
                    if (File.Exists(steam + @"\Gorilla Tag.exe"))
                    {
                        textBoxDirectory.Text = steam;
                        InstallDirectory = steam;
                        platformDetected = true;
                        return;
                    }
                }
            }
            ShowErrorFindingDirectoryMessage();
        }
        private void ShowErrorFindingDirectoryMessage()
        {
            MessageBox.Show("We couldn't seem to find your Gorilla Tag installation, please press \"OK\" and point us to it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            NotFoundHandler();
            this.TopMost = true;
        }
        private string GetSteamLocation()
        {
            string path = RegistryWOW6432.GetRegKey64(RegHive.HKEY_LOCAL_MACHINE, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 1533390", @"InstallLocation");
            if (path != null)
            {
                path = path + @"\";
            }
            return path;
        }
        private void CheckDefaultMod(ReleaseInfo release, ListViewItem item)
        {
            if (release.Name.Contains("BepInEx"))
            {
                item.Checked = true;
                item.ForeColor = System.Drawing.Color.DimGray;
            }
            else
            {
                release.Install = false;
            }
        }
#endregion // Registry

#region RegHelper
        enum RegSAM
        {
            QueryValue = 0x0001,
            SetValue = 0x0002,
            CreateSubKey = 0x0004,
            EnumerateSubKeys = 0x0008,
            Notify = 0x0010,
            CreateLink = 0x0020,
            WOW64_32Key = 0x0200,
            WOW64_64Key = 0x0100,
            WOW64_Res = 0x0300,
            Read = 0x00020019,
            Write = 0x00020006,
            Execute = 0x00020019,
            AllAccess = 0x000f003f
        }

        static class RegHive
        {
            public static UIntPtr HKEY_LOCAL_MACHINE = new UIntPtr(0x80000002u);
            public static UIntPtr HKEY_CURRENT_USER = new UIntPtr(0x80000001u);
        }

        static class RegistryWOW6432
        {
            [DllImport("Advapi32.dll")]
            static extern uint RegOpenKeyEx(UIntPtr hKey, string lpSubKey, uint ulOptions, int samDesired, out int phkResult);

            [DllImport("Advapi32.dll")]
            static extern uint RegCloseKey(int hKey);

            [DllImport("advapi32.dll", EntryPoint = "RegQueryValueEx")]
            public static extern int RegQueryValueEx(int hKey, string lpValueName, int lpReserved, ref uint lpType, System.Text.StringBuilder lpData, ref uint lpcbData);

            static public string GetRegKey64(UIntPtr inHive, String inKeyName, string inPropertyName)
            {
                return GetRegKey64(inHive, inKeyName, RegSAM.WOW64_64Key, inPropertyName);
            }

            static public string GetRegKey32(UIntPtr inHive, String inKeyName, string inPropertyName)
            {
                return GetRegKey64(inHive, inKeyName, RegSAM.WOW64_32Key, inPropertyName);
            }

            static public string GetRegKey64(UIntPtr inHive, String inKeyName, RegSAM in32or64key, string inPropertyName)
            {
                //UIntPtr HKEY_LOCAL_MACHINE = (UIntPtr)0x80000002;
                int hkey = 0;

                try
                {
                    uint lResult = RegOpenKeyEx(RegHive.HKEY_LOCAL_MACHINE, inKeyName, 0, (int)RegSAM.QueryValue | (int)in32or64key, out hkey);
                    if (0 != lResult) return null;
                    uint lpType = 0;
                    uint lpcbData = 1024;
                    StringBuilder AgeBuffer = new StringBuilder(1024);
                    RegQueryValueEx(hkey, inPropertyName, 0, ref lpType, AgeBuffer, ref lpcbData);
                    string Age = AgeBuffer.ToString();
                    return Age;
                }
                finally
                {
                    if (0 != hkey) RegCloseKey(hkey);
                }
            }
        }

#endregion // RegHelper

       

        private void listViewMods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (modsDisabled)
            {
                if (File.Exists(Path.Combine(InstallDirectory, "mods.disable")))
                {
                    File.Move(Path.Combine(InstallDirectory, "mods.disable"), Path.Combine(InstallDirectory, "winhttp.dll"));
                   
                    modsDisabled = false;
                    UpdateStatus("Enabled mods!");
                }
            }
            else
            {
                if (File.Exists(Path.Combine(InstallDirectory, "winhttp.dll")))
                {
                    File.Move(Path.Combine(InstallDirectory, "winhttp.dll"), Path.Combine(InstallDirectory, "mods.disable"));
                   
                    modsDisabled = true;
                    UpdateStatus("Disabled mods!");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/ux4ZbBC6JQ");
        }
    }

}
