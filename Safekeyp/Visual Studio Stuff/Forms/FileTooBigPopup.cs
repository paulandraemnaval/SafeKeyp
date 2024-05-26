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
    public partial class FileTooBigPopup : Form
    {
        private Point parentloc;
        private int parentwidth;
        private int parentheight;
        public FileTooBigPopup(Point parentloc, int parentwidth, int parentheight)
        {
            InitializeComponent();
            this.parentloc = parentloc;
            this.parentwidth = parentwidth;
            this.parentheight = parentheight;
        }

        public void showFileTooBigPopup(SafeKeypMainpage mp)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((mp.Width - this.Width) / 2 + mp.Location.X , (mp.Height - this.Height) / 2 + mp.Location.Y );
            this.ShowDialog();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
