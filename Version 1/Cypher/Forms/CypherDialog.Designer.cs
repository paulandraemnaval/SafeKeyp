namespace Cypher.Forms
{
    partial class CypherDialog
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
            CancelButton = new Button();
            ContinueButton = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(ContinueButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 37);
            panel1.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.LightCoral;
            CancelButton.Dock = DockStyle.Right;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Location = new Point(230, 0);
            CancelButton.Name = "CancelButton";
            CancelButton.Padding = new Padding(1);
            CancelButton.Size = new Size(94, 37);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // ContinueButton
            // 
            ContinueButton.BackColor = Color.LightBlue;
            ContinueButton.Dock = DockStyle.Right;
            ContinueButton.FlatStyle = FlatStyle.Flat;
            ContinueButton.Location = new Point(324, 0);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(94, 37);
            ContinueButton.TabIndex = 0;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = false;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(418, 79);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(321, 88);
            label1.TabIndex = 0;
            label1.Text = "An encrypted version of the file exists\r\nin the selected file's directory. \r\nContinue encryption?\r\n\r\n";
            // 
            // CypherDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 158, 158);
            ClientSize = new Size(418, 116);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CypherDialog";
            Text = "CypherDialog";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ContinueButton;
        private Button CancelButton;
        private Panel panel2;
        private Label label1;
    }
}