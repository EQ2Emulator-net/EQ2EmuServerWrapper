namespace EQ2EmuServerWrapper
{
    partial class Form1
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tcServers = new System.Windows.Forms.TabControl();
            this.tpWorldServer = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcWorldLogs = new System.Windows.Forms.TabControl();
            this.tpWorldAll = new System.Windows.Forms.TabPage();
            this.tpLoginServer = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLoginServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearMainConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllConsolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllConsolesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tcLoginLogs = new System.Windows.Forms.TabControl();
            this.tpLoginAll = new System.Windows.Forms.TabPage();
            this.btnStartLogin = new System.Windows.Forms.Button();
            this.tcServers.SuspendLayout();
            this.tpWorldServer.SuspendLayout();
            this.tcWorldLogs.SuspendLayout();
            this.tpLoginServer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tcLoginLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 409);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(561, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.Enter += new System.EventHandler(this.txtPath_Enter);
            this.txtPath.Leave += new System.EventHandler(this.txtPath_Leave);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(1175, 55);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Open Server";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1175, 122);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(573, 407);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tcServers
            // 
            this.tcServers.Controls.Add(this.tpWorldServer);
            this.tcServers.Controls.Add(this.tpLoginServer);
            this.tcServers.Location = new System.Drawing.Point(2, 52);
            this.tcServers.Name = "tcServers";
            this.tcServers.SelectedIndex = 0;
            this.tcServers.Size = new System.Drawing.Size(1295, 461);
            this.tcServers.TabIndex = 5;
            // 
            // tpWorldServer
            // 
            this.tpWorldServer.Controls.Add(this.label4);
            this.tpWorldServer.Controls.Add(this.label3);
            this.tpWorldServer.Controls.Add(this.label2);
            this.tpWorldServer.Controls.Add(this.label1);
            this.tpWorldServer.Controls.Add(this.tcWorldLogs);
            this.tpWorldServer.Controls.Add(this.txtPath);
            this.tpWorldServer.Controls.Add(this.btnBrowse);
            this.tpWorldServer.Controls.Add(this.btnExit);
            this.tpWorldServer.Controls.Add(this.btnSubmit);
            this.tpWorldServer.Location = new System.Drawing.Point(4, 22);
            this.tpWorldServer.Name = "tpWorldServer";
            this.tpWorldServer.Padding = new System.Windows.Forms.Padding(3);
            this.tpWorldServer.Size = new System.Drawing.Size(1287, 435);
            this.tpWorldServer.TabIndex = 0;
            this.tpWorldServer.Text = "World Server";
            this.tpWorldServer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1185, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1082, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Memory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1185, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1082, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cpu:";
            // 
            // tcWorldLogs
            // 
            this.tcWorldLogs.Controls.Add(this.tpWorldAll);
            this.tcWorldLogs.Location = new System.Drawing.Point(3, 6);
            this.tcWorldLogs.Name = "tcWorldLogs";
            this.tcWorldLogs.SelectedIndex = 0;
            this.tcWorldLogs.Size = new System.Drawing.Size(1073, 394);
            this.tcWorldLogs.TabIndex = 5;
            // 
            // tpWorldAll
            // 
            this.tpWorldAll.Location = new System.Drawing.Point(4, 22);
            this.tpWorldAll.Name = "tpWorldAll";
            this.tpWorldAll.Padding = new System.Windows.Forms.Padding(3);
            this.tpWorldAll.Size = new System.Drawing.Size(1065, 368);
            this.tpWorldAll.TabIndex = 0;
            this.tpWorldAll.Text = "All";
            this.tpWorldAll.UseVisualStyleBackColor = true;
            // 
            // tpLoginServer
            // 
            this.tpLoginServer.Controls.Add(this.btnStartLogin);
            this.tpLoginServer.Controls.Add(this.tcLoginLogs);
            this.tpLoginServer.Location = new System.Drawing.Point(4, 22);
            this.tpLoginServer.Name = "tpLoginServer";
            this.tpLoginServer.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginServer.Size = new System.Drawing.Size(1287, 435);
            this.tpLoginServer.TabIndex = 1;
            this.tpLoginServer.Text = "Login Server";
            this.tpLoginServer.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1297, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWorldServerToolStripMenuItem,
            this.openLoginServerToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1297, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.worldServerToolStripMenuItem,
            this.loginServerToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.settingsToolStripMenuItem.Text = "Edit";
            // 
            // worldServerToolStripMenuItem
            // 
            this.worldServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearMainConsoleToolStripMenuItem,
            this.clearAllConsolesToolStripMenuItem});
            this.worldServerToolStripMenuItem.Name = "worldServerToolStripMenuItem";
            this.worldServerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.worldServerToolStripMenuItem.Text = "World Server";
            // 
            // loginServerToolStripMenuItem
            // 
            this.loginServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearConsoleToolStripMenuItem,
            this.clearAllConsolesToolStripMenuItem1});
            this.loginServerToolStripMenuItem.Name = "loginServerToolStripMenuItem";
            this.loginServerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginServerToolStripMenuItem.Text = "Login Server";
            // 
            // openWorldServerToolStripMenuItem
            // 
            this.openWorldServerToolStripMenuItem.Name = "openWorldServerToolStripMenuItem";
            this.openWorldServerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openWorldServerToolStripMenuItem.Text = "Open World Server";
            this.openWorldServerToolStripMenuItem.Click += new System.EventHandler(this.openWorldServerToolStripMenuItem_Click);
            // 
            // openLoginServerToolStripMenuItem
            // 
            this.openLoginServerToolStripMenuItem.Name = "openLoginServerToolStripMenuItem";
            this.openLoginServerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openLoginServerToolStripMenuItem.Text = "Open Login Server";
            this.openLoginServerToolStripMenuItem.Click += new System.EventHandler(this.openLoginServerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // clearMainConsoleToolStripMenuItem
            // 
            this.clearMainConsoleToolStripMenuItem.Name = "clearMainConsoleToolStripMenuItem";
            this.clearMainConsoleToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.clearMainConsoleToolStripMenuItem.Text = "Clear Console";
            this.clearMainConsoleToolStripMenuItem.Click += new System.EventHandler(this.clearMainConsoleToolStripMenuItem_Click);
            // 
            // clearAllConsolesToolStripMenuItem
            // 
            this.clearAllConsolesToolStripMenuItem.Name = "clearAllConsolesToolStripMenuItem";
            this.clearAllConsolesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.clearAllConsolesToolStripMenuItem.Text = "Clear All Consoles";
            this.clearAllConsolesToolStripMenuItem.Click += new System.EventHandler(this.clearAllConsolesToolStripMenuItem_Click);
            // 
            // clearConsoleToolStripMenuItem
            // 
            this.clearConsoleToolStripMenuItem.Name = "clearConsoleToolStripMenuItem";
            this.clearConsoleToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.clearConsoleToolStripMenuItem.Text = "Clear Console";
            // 
            // clearAllConsolesToolStripMenuItem1
            // 
            this.clearAllConsolesToolStripMenuItem1.Name = "clearAllConsolesToolStripMenuItem1";
            this.clearAllConsolesToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.clearAllConsolesToolStripMenuItem1.Text = "Clear All Consoles";
            // 
            // tcLoginLogs
            // 
            this.tcLoginLogs.Controls.Add(this.tpLoginAll);
            this.tcLoginLogs.Location = new System.Drawing.Point(3, 6);
            this.tcLoginLogs.Name = "tcLoginLogs";
            this.tcLoginLogs.SelectedIndex = 0;
            this.tcLoginLogs.Size = new System.Drawing.Size(1073, 394);
            this.tcLoginLogs.TabIndex = 6;
            // 
            // tpLoginAll
            // 
            this.tpLoginAll.Location = new System.Drawing.Point(4, 22);
            this.tpLoginAll.Name = "tpLoginAll";
            this.tpLoginAll.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginAll.Size = new System.Drawing.Size(1065, 368);
            this.tpLoginAll.TabIndex = 0;
            this.tpLoginAll.Text = "All";
            this.tpLoginAll.UseVisualStyleBackColor = true;
            // 
            // btnStartLogin
            // 
            this.btnStartLogin.Location = new System.Drawing.Point(1111, 41);
            this.btnStartLogin.Name = "btnStartLogin";
            this.btnStartLogin.Size = new System.Drawing.Size(114, 23);
            this.btnStartLogin.TabIndex = 0;
            this.btnStartLogin.Text = "Start Login Server";
            this.btnStartLogin.UseVisualStyleBackColor = true;
            this.btnStartLogin.Click += new System.EventHandler(this.btnStartLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 515);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tcServers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EQ2Emu Server Wrapper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tcServers.ResumeLayout(false);
            this.tpWorldServer.ResumeLayout(false);
            this.tpWorldServer.PerformLayout();
            this.tcWorldLogs.ResumeLayout(false);
            this.tpLoginServer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tcLoginLogs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TabControl tcServers;
        private System.Windows.Forms.TabPage tpWorldServer;
        private System.Windows.Forms.TabPage tpLoginServer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tcWorldLogs;
        private System.Windows.Forms.TabPage tpWorldAll;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem openWorldServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLoginServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worldServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMainConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllConsolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllConsolesToolStripMenuItem1;
        private System.Windows.Forms.TabControl tcLoginLogs;
        private System.Windows.Forms.TabPage tpLoginAll;
        private System.Windows.Forms.Button btnStartLogin;
    }
}

