namespace CypherWithGuna.Forms
{
    partial class FileTooBigPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileTooBigPopup));
            this.ContinueButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContinueButton
            // 
            this.ContinueButton.AnimationHoverSpeed = 0.07F;
            this.ContinueButton.AnimationSpeed = 0.03F;
            this.ContinueButton.BaseColor = System.Drawing.Color.Black;
            this.ContinueButton.BorderColor = System.Drawing.Color.Lime;
            this.ContinueButton.BorderSize = 1;
            this.ContinueButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ContinueButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ContinueButton.CheckedForeColor = System.Drawing.Color.White;
            this.ContinueButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ContinueButton.CheckedImage")));
            this.ContinueButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ContinueButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueButton.ForeColor = System.Drawing.Color.Lime;
            this.ContinueButton.Image = null;
            this.ContinueButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ContinueButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ContinueButton.Location = new System.Drawing.Point(347, 89);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.ContinueButton.OnHoverBorderColor = System.Drawing.Color.Lime;
            this.ContinueButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.ContinueButton.OnHoverImage = null;
            this.ContinueButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.ContinueButton.OnPressedColor = System.Drawing.Color.Black;
            this.ContinueButton.Size = new System.Drawing.Size(96, 39);
            this.ContinueButton.TabIndex = 46;
            this.ContinueButton.Text = "OK";
            this.ContinueButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.ContinueButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 128);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 88);
            this.label1.TabIndex = 45;
            this.label1.Text = "The selected file is too big to encrypt.\r\nThe encryption is limited to files\r\n2 g" +
    "igabytes big.\r\n\r\n";
            // 
            // FileTooBigPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(446, 130);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileTooBigPopup";
            this.Text = "FileTooBigPopup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton ContinueButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}