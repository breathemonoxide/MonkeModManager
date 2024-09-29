namespace MonkeModManager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonFolderBrowser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBepInEx = new System.Windows.Forms.Button();
            this.buttonBackupMods = new System.Windows.Forms.Button();
            this.buttonUninstallAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.contextMenuStripMain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirectory.Enabled = false;
            this.textBoxDirectory.Location = new System.Drawing.Point(12, 342);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(508, 22);
            this.textBoxDirectory.TabIndex = 0;
            // 
            // buttonFolderBrowser
            // 
            this.buttonFolderBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFolderBrowser.Location = new System.Drawing.Point(528, 341);
            this.buttonFolderBrowser.Name = "buttonFolderBrowser";
            this.buttonFolderBrowser.Size = new System.Drawing.Size(26, 23);
            this.buttonFolderBrowser.TabIndex = 1;
            this.buttonFolderBrowser.Text = "..";
            this.buttonFolderBrowser.UseVisualStyleBackColor = true;
            this.buttonFolderBrowser.Click += new System.EventHandler(this.buttonFolderBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gorilla Tag Folder Path:";
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInfoToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(68, 26);
            // 
            // viewInfoToolStripMenuItem
            // 
            this.viewInfoToolStripMenuItem.Name = "viewInfoToolStripMenuItem";
            this.viewInfoToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // buttonBepInEx
            // 
            this.buttonBepInEx.Location = new System.Drawing.Point(294, 301);
            this.buttonBepInEx.Name = "buttonBepInEx";
            this.buttonBepInEx.Size = new System.Drawing.Size(121, 22);
            this.buttonBepInEx.TabIndex = 5;
            this.buttonBepInEx.Text = "BepInEx Folder";
            this.buttonBepInEx.UseVisualStyleBackColor = true;
            this.buttonBepInEx.Click += new System.EventHandler(this.buttonOpenBepInExFolder_Click);
            // 
            // buttonBackupMods
            // 
            this.buttonBackupMods.Location = new System.Drawing.Point(151, 301);
            this.buttonBackupMods.Name = "buttonBackupMods";
            this.buttonBackupMods.Size = new System.Drawing.Size(121, 22);
            this.buttonBackupMods.TabIndex = 1;
            this.buttonBackupMods.Text = "Backup Mods Folder";
            this.buttonBackupMods.UseVisualStyleBackColor = true;
            this.buttonBackupMods.Click += new System.EventHandler(this.buttonBackupMods_Click);
            // 
            // buttonUninstallAll
            // 
            this.buttonUninstallAll.Location = new System.Drawing.Point(15, 301);
            this.buttonUninstallAll.Name = "buttonUninstallAll";
            this.buttonUninstallAll.Size = new System.Drawing.Size(121, 22);
            this.buttonUninstallAll.TabIndex = 0;
            this.buttonUninstallAll.Text = "Uninstall All Mods";
            this.buttonUninstallAll.UseVisualStyleBackColor = true;
            this.buttonUninstallAll.Click += new System.EventHandler(this.buttonUninstallAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "Join The Discord";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.button12);
            this.flowLayoutPanel1.Controls.Add(this.button13);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button11);
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button14);
            this.flowLayoutPanel1.Controls.Add(this.button15);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.button16);
            this.flowLayoutPanel1.Controls.Add(this.button17);
            this.flowLayoutPanel1.Controls.Add(this.button18);
            this.flowLayoutPanel1.Controls.Add(this.button19);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(542, 283);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(363, 31);
            this.button3.TabIndex = 9;
            this.button3.Text = "BepInEx (required)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(372, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 31);
            this.button4.TabIndex = 11;
            this.button4.Text = "Source";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(363, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Utilla - legoandmars | Fixed by AnonymousDonut";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(372, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 31);
            this.button5.TabIndex = 13;
            this.button5.Text = "Source";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(3, 77);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(363, 31);
            this.button6.TabIndex = 14;
            this.button6.Text = "Newtonsoft.JSON - James Newton-King";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(372, 77);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 31);
            this.button7.TabIndex = 15;
            this.button7.Text = "Source";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "                                                                             --us" +
    "eful--";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(3, 201);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(363, 31);
            this.button10.TabIndex = 19;
            this.button10.Text = "SimpleStatsVR - NTkernel";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(372, 164);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(141, 31);
            this.button11.TabIndex = 20;
            this.button11.Text = "Source";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(3, 127);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(363, 31);
            this.button12.TabIndex = 21;
            this.button12.Text = "Yizzi\'s Camera Mod - Yizzi";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(372, 127);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(141, 31);
            this.button13.TabIndex = 22;
            this.button13.Text = "Source";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(3, 164);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(363, 31);
            this.button8.TabIndex = 23;
            this.button8.Text = "Banana OS - Husky";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(372, 201);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(141, 31);
            this.button9.TabIndex = 24;
            this.button9.Text = "Source";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(3, 238);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(363, 31);
            this.button14.TabIndex = 25;
            this.button14.Text = "DisconnectButton - breathemonoxide";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(372, 238);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(141, 31);
            this.button15.TabIndex = 26;
            this.button15.Text = "Source";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "                                                                                 " +
    "--fun--";
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(3, 288);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(363, 31);
            this.button16.TabIndex = 28;
            this.button16.Text = "Gorilla Startup Sounds - breathemonoxide";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(372, 288);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(141, 31);
            this.button17.TabIndex = 29;
            this.button17.Text = "Source";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(3, 325);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(363, 31);
            this.button18.TabIndex = 30;
            this.button18.Text = "Gorilla Homes - Wryser";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(372, 325);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(141, 31);
            this.button19.TabIndex = 31;
            this.button19.Text = "Source";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(566, 376);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBepInEx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBackupMods);
            this.Controls.Add(this.buttonFolderBrowser);
            this.Controls.Add(this.buttonUninstallAll);
            this.Controls.Add(this.textBoxDirectory);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monke Mod Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenuStripMain.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button buttonFolderBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem;
        private System.Windows.Forms.Button buttonUninstallAll;
        private System.Windows.Forms.Button buttonBackupMods;
        private System.Windows.Forms.Button buttonBepInEx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
    }
}

