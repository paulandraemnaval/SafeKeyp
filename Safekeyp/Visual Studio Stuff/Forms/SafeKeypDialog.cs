using CypherWithGuna.Classes;
using Google.Cloud.Firestore;
using System;
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
    public partial class SafeKeypDialog : Form
    {
        public bool result;
        private Point lastLocation;
        private bool mouseDown;
        
        public SafeKeypDialog()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            result = false;
            this.Hide();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            result = true;
            this.Hide();
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastLocation = e.Location;
            this.mouseDown = true;
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        public void showSafeKeypDialog(SafeKeypMainpage mp)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = (new Point((mp.Width - this.Width) / 2 + mp.Location.X, (mp.Height - this.Height) / 2 + mp.Location.Y));
            this.ShowDialog();
        }

        

    }
}
