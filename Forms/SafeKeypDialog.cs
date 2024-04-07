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
        public SafeKeypDialog()
        {
            InitializeComponent();
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
    }
}
