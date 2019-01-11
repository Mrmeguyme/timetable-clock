namespace SplashScreen
{
    sealed partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.contextMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mMove = new System.Windows.Forms.ToolStripMenuItem();
            this.autoAnimatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dontHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mHomepage = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu1
            // 
            this.contextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMove,
            this.mHomepage,
            this.settingsToolStripMenuItem,
            this.themesToolStripMenuItem,
            this.mExit});
            this.contextMenu1.Name = "contextMenu1";
            this.contextMenu1.Size = new System.Drawing.Size(117, 114);
            // 
            // mMove
            // 
            this.mMove.AccessibleName = "";
            this.mMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mMove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoAnimatedToolStripMenuItem,
            this.autoToolStripMenuItem,
            this.dontHideToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.toolStripMenuItem1});
            this.mMove.Name = "mMove";
            this.mMove.Size = new System.Drawing.Size(116, 22);
            this.mMove.Text = "Hide";
            this.mMove.Click += new System.EventHandler(this.mMove_Click_1);
            // 
            // autoAnimatedToolStripMenuItem
            // 
            this.autoAnimatedToolStripMenuItem.Checked = true;
            this.autoAnimatedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoAnimatedToolStripMenuItem.Name = "autoAnimatedToolStripMenuItem";
            this.autoAnimatedToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.autoAnimatedToolStripMenuItem.Text = "Auto (Animated)";
            this.autoAnimatedToolStripMenuItem.Click += new System.EventHandler(this.autoAnimatedToolStripMenuItem_Click);
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            this.autoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.autoToolStripMenuItem.Text = "Auto";
            this.autoToolStripMenuItem.Click += new System.EventHandler(this.autoToolStripMenuItem_Click);
            // 
            // dontHideToolStripMenuItem
            // 
            this.dontHideToolStripMenuItem.Name = "dontHideToolStripMenuItem";
            this.dontHideToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.dontHideToolStripMenuItem.Text = "Don\'t Hide";
            this.dontHideToolStripMenuItem.Click += new System.EventHandler(this.dontHideToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.CheckOnClick = true;
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.hideToolStripMenuItem.Text = "Hide ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem1.Text = "Always On Top";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mHomepage
            // 
            this.mHomepage.Name = "mHomepage";
            this.mHomepage.Size = new System.Drawing.Size(116, 22);
            this.mHomepage.Text = "Help";
            this.mHomepage.Click += new System.EventHandler(this.mHomepage_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.themesToolStripMenuItem.Text = "Themes";
            this.themesToolStripMenuItem.Click += new System.EventHandler(this.themesToolStripMenuItem_Click);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(116, 22);
            this.mExit.Text = "Exit";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Login to fetch table";
            this.notifyIcon1.BalloonTipTitle = "Timetable";
            this.notifyIcon1.ContextMenuStrip = this.contextMenu1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "School Manager";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(210, 68);
            this.ContextMenuStrip = this.contextMenu1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SchoolManager";
            this.Activated += new System.EventHandler(this.frmSplash_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSplash_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frmSplash_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSplash_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmSplash_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmSplash_MouseUp);
            this.contextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu1;
        private System.Windows.Forms.ToolStripMenuItem mHomepage;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem mMove;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem autoAnimatedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dontHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
    }
}

