using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CypherWithGuna.Forms
{
    public partial class SafeKeypErrorPopup : Form
    {
        private Point lastLocation;
        private bool mouseDown;
        private Point safeKeypMainpageLocation;
        private int safeKeypMainpageWidth;
        private int safeKeypMainpageHeight;
        public SafeKeypErrorPopup(Point safeKeypMainpageLocation, int safeKeypMainpageWidth, int safeKeypMainpageHeight)
        {
            InitializeComponent();
            this.safeKeypMainpageLocation = safeKeypMainpageLocation;
            this.safeKeypMainpageWidth = safeKeypMainpageWidth;
            this.safeKeypMainpageHeight = safeKeypMainpageHeight;
            this.DoubleBuffered = true;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastLocation = e.Location;
            this.mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.Location = new Point((this.Location.X - this.lastLocation.X) + e.X, (this.Location.Y - this.lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            
            this.mouseDown = false;
        }

        public void showSafeKeypErrorPopup()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(safeKeypMainpageLocation.X + (safeKeypMainpageWidth - this.Width) / 2, safeKeypMainpageLocation.Y + (safeKeypMainpageHeight - this.Height) / 2);
            this.ShowDialog();
        }
    }


}
