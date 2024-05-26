namespace CypherWithGuna.Forms
{
    partial class SafeKeypErrorPopup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafeKeypErrorPopup));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.EncryptButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.EncryptButton);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 86);
            this.panel1.TabIndex = 0;
            // 
            // EncryptButton
            // 
            this.EncryptButton.AnimationHoverSpeed = 0.07F;
            this.EncryptButton.AnimationSpeed = 0.03F;
            this.EncryptButton.BaseColor = System.Drawing.Color.Black;
            this.EncryptButton.BorderColor = System.Drawing.Color.Lime;
            this.EncryptButton.BorderSize = 1;
            this.EncryptButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.EncryptButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.EncryptButton.CheckedForeColor = System.Drawing.Color.White;
            this.EncryptButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("EncryptButton.CheckedImage")));
            this.EncryptButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.EncryptButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.ForeColor = System.Drawing.Color.Lime;
            this.EncryptButton.Image = null;
            this.EncryptButton.ImageSize = new System.Drawing.Size(20, 20);
            this.EncryptButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EncryptButton.Location = new System.Drawing.Point(329, 50);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.EncryptButton.OnHoverBorderColor = System.Drawing.Color.Lime;
            this.EncryptButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.EncryptButton.OnHoverImage = null;
            this.EncryptButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.EncryptButton.OnPressedColor = System.Drawing.Color.Black;
            this.EncryptButton.Size = new System.Drawing.Size(88, 36);
            this.EncryptButton.TabIndex = 41;
            this.EncryptButton.Text = "OK";
            this.EncryptButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EncryptButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 8F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Error in decryption. Invalid encrypted file\r\nselected or incorrect key";
            // 
            // SafeKeypErrorPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(419, 88);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SafeKeypErrorPopup";
            this.Text = "ErrorDialog";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton EncryptButton;
    }
}