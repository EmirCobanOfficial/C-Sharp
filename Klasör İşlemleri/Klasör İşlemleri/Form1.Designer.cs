namespace Klasör_İşlemleri
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
            this.btn_klasorolustur = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_klasorsil = new System.Windows.Forms.Button();
            this.btn_yolkontrol = new System.Windows.Forms.Button();
            this.btn_olusturulma = new System.Windows.Forms.Button();
            this.btn_programfiles = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sonerisimzamanı = new System.Windows.Forms.Button();
            this.btn_klasoraddegistir = new System.Windows.Forms.Button();
            this.btn_sürücüler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_klasorolustur
            // 
            this.btn_klasorolustur.Location = new System.Drawing.Point(12, 12);
            this.btn_klasorolustur.Name = "btn_klasorolustur";
            this.btn_klasorolustur.Size = new System.Drawing.Size(123, 45);
            this.btn_klasorolustur.TabIndex = 0;
            this.btn_klasorolustur.Text = "create folder";
            this.btn_klasorolustur.UseVisualStyleBackColor = true;
            this.btn_klasorolustur.Click += new System.EventHandler(this.btn_klasorolustur_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(393, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(274, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "folder name:";
            // 
            // btn_klasorsil
            // 
            this.btn_klasorsil.Location = new System.Drawing.Point(12, 63);
            this.btn_klasorsil.Name = "btn_klasorsil";
            this.btn_klasorsil.Size = new System.Drawing.Size(123, 45);
            this.btn_klasorsil.TabIndex = 3;
            this.btn_klasorsil.Text = "delete folder";
            this.btn_klasorsil.UseVisualStyleBackColor = true;
            this.btn_klasorsil.Click += new System.EventHandler(this.btn_klasorsil_Click);
            // 
            // btn_yolkontrol
            // 
            this.btn_yolkontrol.Location = new System.Drawing.Point(12, 114);
            this.btn_yolkontrol.Name = "btn_yolkontrol";
            this.btn_yolkontrol.Size = new System.Drawing.Size(123, 45);
            this.btn_yolkontrol.TabIndex = 4;
            this.btn_yolkontrol.Text = "control folder";
            this.btn_yolkontrol.UseVisualStyleBackColor = true;
            this.btn_yolkontrol.Click += new System.EventHandler(this.btn_yolkontrol_Click);
            // 
            // btn_olusturulma
            // 
            this.btn_olusturulma.Location = new System.Drawing.Point(12, 165);
            this.btn_olusturulma.Name = "btn_olusturulma";
            this.btn_olusturulma.Size = new System.Drawing.Size(123, 45);
            this.btn_olusturulma.TabIndex = 5;
            this.btn_olusturulma.Text = "date of creation";
            this.btn_olusturulma.UseVisualStyleBackColor = true;
            this.btn_olusturulma.Click += new System.EventHandler(this.btn_olusturulma_Click);
            // 
            // btn_programfiles
            // 
            this.btn_programfiles.Location = new System.Drawing.Point(12, 216);
            this.btn_programfiles.Name = "btn_programfiles";
            this.btn_programfiles.Size = new System.Drawing.Size(123, 45);
            this.btn_programfiles.TabIndex = 6;
            this.btn_programfiles.Text = "Program Files";
            this.btn_programfiles.UseVisualStyleBackColor = true;
            this.btn_programfiles.Click += new System.EventHandler(this.btn_programfiles_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(278, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(578, 292);
            this.listBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(467, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Program Files";
            // 
            // btn_sonerisimzamanı
            // 
            this.btn_sonerisimzamanı.Location = new System.Drawing.Point(12, 267);
            this.btn_sonerisimzamanı.Name = "btn_sonerisimzamanı";
            this.btn_sonerisimzamanı.Size = new System.Drawing.Size(123, 45);
            this.btn_sonerisimzamanı.TabIndex = 9;
            this.btn_sonerisimzamanı.Text = "last access date";
            this.btn_sonerisimzamanı.UseVisualStyleBackColor = true;
            this.btn_sonerisimzamanı.Click += new System.EventHandler(this.btn_sonerisimzamanı_Click);
            // 
            // btn_klasoraddegistir
            // 
            this.btn_klasoraddegistir.Location = new System.Drawing.Point(12, 318);
            this.btn_klasoraddegistir.Name = "btn_klasoraddegistir";
            this.btn_klasoraddegistir.Size = new System.Drawing.Size(123, 45);
            this.btn_klasoraddegistir.TabIndex = 10;
            this.btn_klasoraddegistir.Text = "change folder name";
            this.btn_klasoraddegistir.UseVisualStyleBackColor = true;
            this.btn_klasoraddegistir.Click += new System.EventHandler(this.btn_klasoraddegistir_Click);
            // 
            // btn_sürücüler
            // 
            this.btn_sürücüler.Location = new System.Drawing.Point(12, 369);
            this.btn_sürücüler.Name = "btn_sürücüler";
            this.btn_sürücüler.Size = new System.Drawing.Size(123, 45);
            this.btn_sürücüler.TabIndex = 11;
            this.btn_sürücüler.Text = "drivers";
            this.btn_sürücüler.UseVisualStyleBackColor = true;
            this.btn_sürücüler.Click += new System.EventHandler(this.btn_sürücüler_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "top index";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(982, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_sürücüler);
            this.Controls.Add(this.btn_klasoraddegistir);
            this.Controls.Add(this.btn_sonerisimzamanı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_programfiles);
            this.Controls.Add(this.btn_olusturulma);
            this.Controls.Add(this.btn_yolkontrol);
            this.Controls.Add(this.btn_klasorsil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_klasorolustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_klasorolustur;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_klasorsil;
        private System.Windows.Forms.Button btn_yolkontrol;
        private System.Windows.Forms.Button btn_olusturulma;
        private System.Windows.Forms.Button btn_programfiles;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sonerisimzamanı;
        private System.Windows.Forms.Button btn_klasoraddegistir;
        private System.Windows.Forms.Button btn_sürücüler;
        private System.Windows.Forms.Button button1;
    }
}

