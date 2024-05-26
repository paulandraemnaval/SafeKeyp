﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CypherWithGuna.Forms
{
    public partial class DecryptForm : Form
    {
        public SafeKeypMainpage mp;
        public DecryptForm()
        {
            InitializeComponent();
            this.Focus();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowDecryptDialog(SafeKeypMainpage mp)
        {
            this.mp = mp;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((mp.Width - this.Width) / 2 + mp.Location.X, (mp.Height - this.Width) / 2 + mp.Location.Y);
            this.ShowDialog();
        }
    }
}