namespace DARP_00026919_2EP
{
    partial class Form1
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
            this.uControlAdmin1 = new DARP_00026919_2EP.UControlAdmin();
            this.SuspendLayout();
            // 
            // uControlAdmin1
            // 
            this.uControlAdmin1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uControlAdmin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uControlAdmin1.Location = new System.Drawing.Point(0, 0);
            this.uControlAdmin1.Name = "uControlAdmin1";
            this.uControlAdmin1.Size = new System.Drawing.Size(612, 438);
            this.uControlAdmin1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 438);
            this.Controls.Add(this.uControlAdmin1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private DARP_00026919_2EP.UControlAdmin uControlAdmin1;
    }
}