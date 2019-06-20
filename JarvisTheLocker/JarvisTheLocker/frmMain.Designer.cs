namespace JarvisTheLocker
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstLockedFiles = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bgwFileOpener = new System.ComponentModel.BackgroundWorker();
            this.bgwCrypto = new System.ComponentModel.BackgroundWorker();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(452, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Enabled = false;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // lstLockedFiles
            // 
            this.lstLockedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLockedFiles.Enabled = false;
            this.lstLockedFiles.FormattingEnabled = true;
            this.lstLockedFiles.ItemHeight = 16;
            this.lstLockedFiles.Location = new System.Drawing.Point(4, 19);
            this.lstLockedFiles.Margin = new System.Windows.Forms.Padding(4);
            this.lstLockedFiles.Name = "lstLockedFiles";
            this.lstLockedFiles.Size = new System.Drawing.Size(412, 179);
            this.lstLockedFiles.TabIndex = 2;
            this.lstLockedFiles.SelectedIndexChanged += new System.EventHandler(this.lstLockedFiles_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstLockedFiles);
            this.groupBox1.Location = new System.Drawing.Point(16, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(420, 202);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locked Files";
            // 
            // bgwFileOpener
            // 
            this.bgwFileOpener.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFileOpener_DoWork);
            this.bgwFileOpener.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFileOpener_RunWorkerCompleted);
            // 
            // bgwCrypto
            // 
            this.bgwCrypto.WorkerReportsProgress = true;
            this.bgwCrypto.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCrypto_DoWork);
            this.bgwCrypto.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCrypto_RunWorkerCompleted);
            // 
            // btnUnlock
            // 
            this.btnUnlock.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUnlock.Enabled = false;
            this.btnUnlock.FlatAppearance.BorderSize = 0;
            this.btnUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnlock.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlock.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUnlock.Location = new System.Drawing.Point(291, 33);
            this.btnUnlock.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(137, 59);
            this.btnUnlock.TabIndex = 8;
            this.btnUnlock.Text = "Decrypt";
            this.btnUnlock.UseVisualStyleBackColor = false;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLock.Enabled = false;
            this.btnLock.FlatAppearance.BorderSize = 0;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLock.Location = new System.Drawing.Point(20, 33);
            this.btnLock.Margin = new System.Windows.Forms.Padding(4);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(137, 59);
            this.btnLock.TabIndex = 7;
            this.btnLock.Text = "Encrypt";
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Location = new System.Drawing.Point(20, 304);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(416, 59);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 378);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(467, 346);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Jarvis The Locker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox lstLockedFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker bgwFileOpener;
        private System.ComponentModel.BackgroundWorker bgwCrypto;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnExit;
    }
}

