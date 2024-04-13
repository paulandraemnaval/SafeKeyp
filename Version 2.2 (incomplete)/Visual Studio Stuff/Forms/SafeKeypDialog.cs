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
        private Point safeKeypMainpageLocation;
        private int safeKeypMainpageWidth;
        private int safeKeypMainpageHeight;
        public SafeKeypDialog(Point safeKeypMainpageLocation, int safeKeypMainpageWidth, int safeKeypMainpageHeight)
        {
            InitializeComponent();
            this.safeKeypMainpageLocation = safeKeypMainpageLocation;
            this.safeKeypMainpageWidth = safeKeypMainpageWidth;
            this.safeKeypMainpageHeight = safeKeypMainpageHeight;
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
            if(mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        public void showSafeKeypDialog()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(safeKeypMainpageLocation.X + (safeKeypMainpageWidth - this.Width)/2, safeKeypMainpageLocation.Y + (safeKeypMainpageHeight-this.Height) /2 );
            this.ShowDialog();
        }
    }
}
