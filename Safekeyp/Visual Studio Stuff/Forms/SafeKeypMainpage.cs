using CypherWithGuna.Classes;
using CypherWithGuna.Forms;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CypherWithGuna
{
    public partial class SafeKeypMainpage : Form
    {
        
        //for animation

        
        //for dragging
        private bool mouseDown; //lower case because MouseDown is already defined.
        private Point LastLocation;

        public SafeKeypMainpage()
        {
            InitializeComponent();
            
            this.DoubleBuffered = true;
            
            ChangeTextTimer.Start();
            MoveTimer.Start();

        }




        //EVENTS
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void FormBar_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.LastLocation = e.Location;
        }
        private void FormBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                this.Location = new Point((this.Location.X - this.LastLocation.X) + e.X, (this.Location.Y - this.LastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void FormBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            
            EncryptForm ef = new EncryptForm();
            ef.ShowEncryptDialog(this);
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            this.DecryptButton.Update();
            DecryptForm df = new DecryptForm();
            df.ShowDecryptDialog(this);
        }

        private void SafeKeypMainpageTimer_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            
            


            if(label1.Top >= this.Height)
            {
                label1.Top = -label1.Height;
            }
            if (label2.Top >= this.Height)
            {
                label2.Top = - label2.Height;
            }
            if (label3.Top >= this.Height)
            {
                label3.Top = - label3.Height;
            }
            if (label4.Top >= this.Height)
            {
                label4.Top = - label4.Height;
            }
            if (label5.Top >= this.Height)
            {
                label5.Top = - label5.Height;
            }
            if(label6.Top >= this.Height)
            {
                label6.Top = - label6.Height;
            }
            if(label7.Top >= this.Height)
            {
                label7.Top = - label7.Height;
            }
            if(label8.Top >= this.Height)
            {
                label8.Top = - label8.Height;
            }
            if(label9.Top >= this.Height)
            {
                label9.Top = - label9.Height;

            }

            char[] newtext = new char[32];
            char[] newtext2 = new char[32];
            char[] newtext3 = new char[32];
            char[] newtext4 = new char[32];
            char[] newtext5 = new char[32];
            char[] newtext6 = new char[32];
            char[] newtext7 = new char[32];
            char[] newtext8 = new char[32];
            char[] newtext9 = new char[32];
            char[] newtext10 = new char[32];
           

            

            char[] chars = "@#$%&()ABCDEFGHIJKLMNOP0123456789".ToCharArray();
            for(int i = 0; i < 32; i+=2)
            {

                newtext[i] = chars[ran.Next(0, chars.Length)];
                newtext[i + 1] = '\n';
                newtext2[i] = chars[ran.Next(0, chars.Length)];
                newtext2[i + 1] = '\n';
                newtext3[i] = chars[ran.Next(0, chars.Length)];
                newtext3[i + 1] = '\n';
                newtext4[i] = chars[ran.Next(0, chars.Length)];
                newtext4[i + 1] = '\n';
                newtext5[i] = chars[ran.Next(0, chars.Length)];
                newtext5[i + 1] = '\n';
                newtext6[i] = chars[ran.Next(0, chars.Length)];
                newtext6[i + 1] = '\n';
                newtext7[i] = chars[ran.Next(0, chars.Length)];
                newtext7[i + 1] = '\n';
                newtext8[i] = chars[ran.Next(0, chars.Length)];
                newtext8[i + 1] = '\n';
                newtext9[i] = chars[ran.Next(0, chars.Length)];
                newtext9[i + 1] = '\n';
                newtext10[i] = chars[ran.Next(0, chars.Length)];
                newtext10[i + 1] = '\n';

            }
            label1.Text = new string(newtext);
            label2.Text = new string(newtext2);
            label3.Text = new string(newtext3);
            label4.Text = new string(newtext4);
            label5.Text = new string(newtext5);
            label6.Text = new string(newtext6);
            label7.Text = new string(newtext7);
            label8.Text = new string(newtext8);
            label9.Text = new string(newtext9);
            
            
        }
        
       
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            label1.Top += ran.Next(1,5);
            label2.Top += ran.Next(1,5);
            label3.Top += ran.Next(1,5);
            label4.Top += ran.Next(1,5);
            label5.Top += ran.Next(1,5);
            label6.Top += ran.Next(1,5);
            label7.Top += ran.Next(1,5);
            label8.Top += ran.Next(1,5);
            label9.Top += ran.Next(1,5);
        }
    }
}
