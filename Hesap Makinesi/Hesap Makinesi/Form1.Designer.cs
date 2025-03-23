namespace Hesap_Makinesi
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(22, 32);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Sayı1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 81);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Sayı2:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 27);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(34, 133);
            button1.Name = "button1";
            button1.Size = new Size(120, 43);
            button1.TabIndex = 4;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(248, 61);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "Sonuç:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(306, 61);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 6;
            label4.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(306, 309);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 13;
            label5.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(248, 309);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 12;
            label6.Text = "Sonuç:";
            // 
            // button2
            // 
            button2.Location = new Point(34, 381);
            button2.Name = "button2";
            button2.Size = new Size(120, 43);
            button2.TabIndex = 11;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(100, 280);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(79, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(100, 326);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(79, 27);
            textBox4.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(22, 329);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 8;
            label7.Text = "Sayı2:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(22, 280);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 7;
            label8.Text = "Sayı1:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(77, 9);
            label9.Name = "label9";
            label9.Size = new Size(143, 20);
            label9.TabIndex = 14;
            label9.Text = "TOPLAMA CIKARMA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(77, 241);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 15;
            label10.Text = "CARPMA BÖLME";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(343, 503);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hesap Makinesi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
