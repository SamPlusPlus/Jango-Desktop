using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jango_Desktop
{
    public partial class KeyCatcher : Form
    {
        Keys newShortcut;
        public KeyCatcher()
        {
            InitializeComponent();
        }

        private void KeyCatcher_KeyDown(object sender, KeyEventArgs e)
        {

            shortcut.Text = e.KeyData.ToString();
            newShortcut = e.KeyData;
        }

        public Keys getShortCut()
        {
            return newShortcut;
        }

        private void KeyCatcher_KeyUp(object sender, KeyEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
