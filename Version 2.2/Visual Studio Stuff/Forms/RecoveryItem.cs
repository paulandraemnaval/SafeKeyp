using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CypherWithGuna.Forms
{
    public partial class RecoveryItem : UserControl
    {
        private string StoredPath;
        public RecoveryItem(string path)
        {
            InitializeComponent();
            this.StoredPath = path;
            this.DirectoryLabel.Text = Path.GetFileName(path);
        }
        public RecoveryItem()
        {
            InitializeComponent();
            this.DirectoryLabel.Text = "No items found";
            this.StoredPath = "";
            this.RecoverButton.Visible = false;
        }

        private void RecoverButton_Click(object sender, EventArgs e)
        {
            RecoverKeyForm rkf = new RecoverKeyForm(StoredPath);
            rkf.ShowDialog();
        }
    }
}
