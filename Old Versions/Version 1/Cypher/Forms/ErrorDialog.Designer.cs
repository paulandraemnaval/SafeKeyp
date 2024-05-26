namespace Cypher.Forms
{
    partial class ErrorDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            OKButton = new Button();
            panel2 = new Panel();
            ErrorInfo = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(OKButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 37);
            panel1.TabIndex = 0;
            // 
            // OKButton
            // 
            OKButton.BackColor = Color.LightBlue;
            OKButton.Dock = DockStyle.Right;
            OKButton.FlatStyle = FlatStyle.Flat;
            OKButton.Location = new Point(324, 0);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(94, 37);
            OKButton.TabIndex = 1;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = false;
            OKButton.Click += OKButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(ErrorInfo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(418, 79);
            panel2.TabIndex = 1;
            // 
            // ErrorInfo
            // 
            ErrorInfo.AutoSize = true;
            ErrorInfo.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorInfo.Location = new Point(12, 7);
            ErrorInfo.Name = "ErrorInfo";
            ErrorInfo.Size = new Size(309, 44);
            ErrorInfo.TabIndex = 1;
            ErrorInfo.Text = "Error in decryption. This file was not\r\nencrypted by this application\r\n";
            ErrorInfo.Click += label1_Click;
            // 
            // ErrorDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 158, 158);
            ClientSize = new Size(418, 116);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ErrorDialog";
            Text = "ErrorDialog";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label ErrorInfo;
        private Button OKButton;
    }
}