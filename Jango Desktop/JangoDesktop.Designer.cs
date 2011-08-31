namespace Jango_Desktop
{
    partial class JangoDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JangoDesktop));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.JangoContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playPauseSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayCurrentSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rateSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.badToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLyricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToClipBoardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hideJangoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutJangoDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songCheckerTimer = new System.Windows.Forms.Timer(this.components);
            this.JangoBrowser = new Skybound.Gecko.GeckoWebBrowser();
            this.JangoContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.JangoContextMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Jango Desktop";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // JangoContextMenu
            // 
            this.JangoContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playPauseSongToolStripMenuItem,
            this.nextTrackToolStripMenuItem,
            this.displayCurrentSongToolStripMenuItem,
            this.rateSongToolStripMenuItem,
            this.showLyricsToolStripMenuItem,
            this.toolStripSeparator1,
            this.SettingsToolStripMenuItem,
            this.CopyToClipBoardToolStripMenuItem1,
            this.toolStripSeparator2,
            this.hideJangoToolStripMenuItem,
            this.aboutJangoDesktopToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.JangoContextMenu.Name = "JangoContextMenu";
            this.JangoContextMenu.Size = new System.Drawing.Size(188, 258);
            // 
            // playPauseSongToolStripMenuItem
            // 
            this.playPauseSongToolStripMenuItem.Image = global::Jango_Desktop.Properties.Resources.control_play;
            this.playPauseSongToolStripMenuItem.Name = "playPauseSongToolStripMenuItem";
            this.playPauseSongToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.playPauseSongToolStripMenuItem.Text = "Play/Pause  Song";
            this.playPauseSongToolStripMenuItem.Click += new System.EventHandler(this.playPauseSongToolStripMenuItem_Click);
            // 
            // nextTrackToolStripMenuItem
            // 
            this.nextTrackToolStripMenuItem.Image = global::Jango_Desktop.Properties.Resources.control_fastforward;
            this.nextTrackToolStripMenuItem.Name = "nextTrackToolStripMenuItem";
            this.nextTrackToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.nextTrackToolStripMenuItem.Text = "Next Track";
            this.nextTrackToolStripMenuItem.Click += new System.EventHandler(this.nextTrackToolStripMenuItem_Click);
            // 
            // displayCurrentSongToolStripMenuItem
            // 
            this.displayCurrentSongToolStripMenuItem.Image = global::Jango_Desktop.Properties.Resources.comment;
            this.displayCurrentSongToolStripMenuItem.Name = "displayCurrentSongToolStripMenuItem";
            this.displayCurrentSongToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.displayCurrentSongToolStripMenuItem.Text = "Display Current Song";
            this.displayCurrentSongToolStripMenuItem.Click += new System.EventHandler(this.displayCurrentSongToolStripMenuItem_Click);
            // 
            // rateSongToolStripMenuItem
            // 
            this.rateSongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greatToolStripMenuItem,
            this.badToolStripMenuItem});
            this.rateSongToolStripMenuItem.Image = global::Jango_Desktop.Properties.Resources.star;
            this.rateSongToolStripMenuItem.Name = "rateSongToolStripMenuItem";
            this.rateSongToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.rateSongToolStripMenuItem.Text = "Rate Song";
            // 
            // greatToolStripMenuItem
            // 
            this.greatToolStripMenuItem.Image = global::Jango_Desktop.Properties.Resources.emoticon_happy;
            this.greatToolStripMenuItem.Name = "greatToolStripMenuItem";
            this.greatToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.greatToolStripMenuItem.Text = "Love";
            this.greatToolStripMenuItem.Click += new System.EventHandler(this.greatToolStripMenuItem_Click);
            // 
            // badToolStripMenuItem
            // 
            this.badToolStripMenuItem.Image = global::Jango_Desktop.Properties.Resources.emoticon_unhappy;
            this.badToolStripMenuItem.Name = "badToolStripMenuItem";
            this.badToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.badToolStripMenuItem.Text = "Hate";
            this.badToolStripMenuItem.Click += new System.EventHandler(this.badToolStripMenuItem_Click);
            // 
            // showLyricsToolStripMenuItem
            // 
            this.showLyricsToolStripMenuItem.Image = global::Jango_Desktop.Properties.Resources.text_align_justify;
            this.showLyricsToolStripMenuItem.Name = "showLyricsToolStripMenuItem";
            this.showLyricsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.showLyricsToolStripMenuItem.Text = "Show Lyrics ";
            this.showLyricsToolStripMenuItem.Click += new System.EventHandler(this.showLyricsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Image = global::Jango_Desktop.Properties.Resources.wrench_orange;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.SettingsToolStripMenuItem.Text = "Settings";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // CopyToClipBoardToolStripMenuItem1
            // 
            this.CopyToClipBoardToolStripMenuItem1.Enabled = false;
            this.CopyToClipBoardToolStripMenuItem1.Image = global::Jango_Desktop.Properties.Resources.attach;
            this.CopyToClipBoardToolStripMenuItem1.Name = "CopyToClipBoardToolStripMenuItem1";
            this.CopyToClipBoardToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.CopyToClipBoardToolStripMenuItem1.Text = "Copy to Clipboard";
            this.CopyToClipBoardToolStripMenuItem1.Click += new System.EventHandler(this.CopyToClipBoardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // hideJangoToolStripMenuItem
            // 
            this.hideJangoToolStripMenuItem.Image = global::Jango_Desktop.Properties.Resources.eye;
            this.hideJangoToolStripMenuItem.Name = "hideJangoToolStripMenuItem";
            this.hideJangoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.hideJangoToolStripMenuItem.Text = "Hide Jango Desktop ";
            this.hideJangoToolStripMenuItem.Click += new System.EventHandler(this.hideJangoToolStripMenuItem_Click);
            // 
            // aboutJangoDesktopToolStripMenuItem
            // 
            this.aboutJangoDesktopToolStripMenuItem.Image = global::Jango_Desktop.Properties.Resources.information;
            this.aboutJangoDesktopToolStripMenuItem.Name = "aboutJangoDesktopToolStripMenuItem";
            this.aboutJangoDesktopToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aboutJangoDesktopToolStripMenuItem.Text = "About Jango Desktop";
            this.aboutJangoDesktopToolStripMenuItem.Click += new System.EventHandler(this.aboutJangoDesktopToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Jango_Desktop.Properties.Resources.cancel;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // songCheckerTimer
            // 
            this.songCheckerTimer.Enabled = true;
            this.songCheckerTimer.Interval = 1000;
            this.songCheckerTimer.Tick += new System.EventHandler(this.songCheckerTimer_Tick);
            // 
            // JangoBrowser
            // 
            this.JangoBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JangoBrowser.Location = new System.Drawing.Point(0, 0);
            this.JangoBrowser.Name = "JangoBrowser";
            this.JangoBrowser.Size = new System.Drawing.Size(997, 284);
            this.JangoBrowser.TabIndex = 1;
            // 
            // JangoDesktop
            // 
            this.ClientSize = new System.Drawing.Size(997, 284);
            this.Controls.Add(this.JangoBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JangoDesktop";
            this.ShowInTaskbar = false;
            this.Text = "Jango Desktop";
            this.Load += new System.EventHandler(this.JangoDesktop_Load);
            this.Resize += new System.EventHandler(this.JangoDesktop_Resize);
            this.JangoContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer songCheckerTimer;
        private System.Windows.Forms.ContextMenuStrip JangoContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutJangoDesktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideJangoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLyricsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rateSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem greatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem badToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayCurrentSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playPauseSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToClipBoardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Skybound.Gecko.GeckoWebBrowser JangoBrowser;
    }
}

