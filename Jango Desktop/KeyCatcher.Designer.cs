namespace Jango_Desktop
{
    partial class KeyCatcher
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
            this.shortcut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shortcut
            // 
            this.shortcut.AutoSize = true;
            this.shortcut.Location = new System.Drawing.Point(13, 13);
            this.shortcut.Name = "shortcut";
            this.shortcut.Size = new System.Drawing.Size(159, 13);
            this.shortcut.TabIndex = 0;
            this.shortcut.Text = "Start typing the desired shortcut.";
            // 
            // KeyCatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 53);
            this.Controls.Add(this.shortcut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KeyCatcher";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Keyboard Shortcut";
            this.TopMost = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyCatcher_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyCatcher_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shortcut;
    }
}