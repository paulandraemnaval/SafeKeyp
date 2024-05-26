using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cypher.Forms
{
    public partial class CypherTextBox : UserControl
    {
        private Color borderColor = Color.FromArgb(231, 203, 227);

        private Color focusedColors = Color.FromArgb(179, 190, 209);
        private bool underlinedStyle = true;
        private int borderSize = 10;
        public string placeholder;


        public CypherTextBox()
        {
            InitializeComponent();
            this.textBox1.Enter += textBox1_Enter;
            this.textBox1.KeyPress += textBox1_KeyPress;
            this.textBox1.Leave += textBox1_Leave;
        }

        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public Color FocusedColors { get => focusedColors; set { focusedColors = value; this.Invalidate(); } }
        public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle = value; this.Invalidate(); } }
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }

        override public string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; placeholder = textBox1.Text; this.Invalidate(); }
        }

        public string Placeholder
        {
            get { return placeholder; }
            set { placeholder = value; textBox1.Text = value; this.Invalidate(); }
        }

        public Boolean isPassword
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; this.Invalidate(); }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Clear(this.BackColor);
            using (Pen p = new Pen(borderColor, borderSize))
            {
                p.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (underlinedStyle)
                    g.DrawLine(p, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    g.DrawRectangle(p, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = focusedColors;
            this.BackColor = focusedColors;
            if (this.Text.Trim() == this.placeholder)
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            this.BackColor = Color.White;
            if (this.Text.Trim() == "")
            {
                this.textBox1.Text = this.placeholder;
                this.isPassword = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
