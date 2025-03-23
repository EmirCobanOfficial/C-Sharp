namespace NumericUpDown
{
    partial class EkranAlıntısı
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
            this.görüntüal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // görüntüal
            // 
            this.görüntüal.Location = new System.Drawing.Point(12, 23);
            this.görüntüal.Name = "görüntüal";
            this.görüntüal.Size = new System.Drawing.Size(130, 50);
            this.görüntüal.TabIndex = 0;
            this.görüntüal.Text = "Görüntü Al";
            this.görüntüal.UseVisualStyleBackColor = true;
            this.görüntüal.Click += new System.EventHandler(this.görüntüal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(158, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(888, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // EkranAlıntısı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 568);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.görüntüal);
            this.Name = "EkranAlıntısı";
            this.Text = "EkranAlıntısı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button görüntüal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}