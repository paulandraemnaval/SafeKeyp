namespace CypherWithGuna.Forms
{
    partial class SafeKeypDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafeKeypDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ContinueButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.ContinueButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 128);
            this.panel1.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.AnimationHoverSpeed = 0.07F;
            this.CancelButton.AnimationSpeed = 0.03F;
            this.CancelButton.BaseColor = System.Drawing.Color.Black;
            this.CancelButton.BorderColor = System.Drawing.Color.Red;
            this.CancelButton.BorderSize = 1;
            this.CancelButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CancelButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CancelButton.CheckedForeColor = System.Drawing.Color.White;
            this.CancelButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("CancelButton.CheckedImage")));
            this.CancelButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CancelButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Red;
            this.CancelButton.Image = null;
            this.CancelButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CancelButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CancelButton.Location = new System.Drawing.Point(253, 89);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.CancelButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CancelButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.CancelButton.OnHoverImage = null;
            this.CancelButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.CancelButton.OnPressedColor = System.Drawing.Color.Black;
            this.CancelButton.Size = new System.Drawing.Size(96, 39);
            this.CancelButton.TabIndex = 47;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            this.ContinueButton.Location = new System.Drawing.Point(349, 89);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.ContinueButton.OnHoverBorderColor = System.Drawing.Color.Lime;
            this.ContinueButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.ContinueButton.OnHoverImage = null;
            this.ContinueButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.ContinueButton.OnPressedColor = System.Drawing.Color.Black;
            this.ContinueButton.Size = new System.Drawing.Size(96, 39);
            this.ContinueButton.TabIndex = 46;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 66);
            this.label1.TabIndex = 45;
            this.label1.Text = "An encrypted version of the file exists\r\nin the selected directory. \r\nContinue wi" +
    "th encryption?";
            // 
            // SafeKeypDialog
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(446, 130);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SafeKeypDialog";
            this.Text = "SafeKeypDialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private new Guna.UI.WinForms.GunaAdvenceButton CancelButton;
        private Guna.UI.WinForms.GunaAdvenceButton ContinueButton;
        private System.Windows.Forms.Label label1;
    }
}