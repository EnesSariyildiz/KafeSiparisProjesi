namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.siparisLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // siparisLabel
            // 
            this.siparisLabel.AutoSize = true;
            this.siparisLabel.Location = new System.Drawing.Point(85, 51);
            this.siparisLabel.Name = "siparisLabel";
            this.siparisLabel.Size = new System.Drawing.Size(43, 15);
            this.siparisLabel.TabIndex = 0;
            this.siparisLabel.Text = "asdasd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 116);
            this.Controls.Add(this.siparisLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label siparisLabel;
    }
}