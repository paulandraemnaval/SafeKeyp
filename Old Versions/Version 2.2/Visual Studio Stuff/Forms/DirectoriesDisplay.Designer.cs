namespace CypherWithGuna.Forms
{
    partial class DirectoriesDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DirectoriesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // DirectoriesPanel
            // 
            this.DirectoriesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirectoriesPanel.Location = new System.Drawing.Point(0, 0);
            this.DirectoriesPanel.Name = "DirectoriesPanel";
            this.DirectoriesPanel.Size = new System.Drawing.Size(467, 368);
            this.DirectoriesPanel.TabIndex = 0;
            // 
            // DirectoriesDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.DirectoriesPanel);
            this.Name = "DirectoriesDisplay";
            this.Size = new System.Drawing.Size(467, 368);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel DirectoriesPanel;
    }
}
