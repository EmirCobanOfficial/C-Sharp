namespace Sehir_Tahmin_Oyunu
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
            this.grpgame = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yourremainingentitlement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enteredletters = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpredict = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_letterenter = new System.Windows.Forms.Button();
            this.txt_letter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpgame
            // 
            this.grpgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpgame.Location = new System.Drawing.Point(338, 119);
            this.grpgame.Name = "grpgame";
            this.grpgame.Size = new System.Drawing.Size(448, 158);
            this.grpgame.TabIndex = 0;
            this.grpgame.TabStop = false;
            this.grpgame.Text = "Question";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yourremainingentitlement);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.enteredletters);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnpredict);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.btn_letterenter);
            this.groupBox2.Controls.Add(this.txt_letter);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(338, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Answer";
            // 
            // yourremainingentitlement
            // 
            this.yourremainingentitlement.AutoSize = true;
            this.yourremainingentitlement.Location = new System.Drawing.Point(294, 120);
            this.yourremainingentitlement.Name = "yourremainingentitlement";
            this.yourremainingentitlement.Size = new System.Drawing.Size(24, 25);
            this.yourremainingentitlement.TabIndex = 6;
            this.yourremainingentitlement.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "your remaining entitlement:";
            // 
            // enteredletters
            // 
            this.enteredletters.AutoSize = true;
            this.enteredletters.Location = new System.Drawing.Point(180, 76);
            this.enteredletters.Name = "enteredletters";
            this.enteredletters.Size = new System.Drawing.Size(0, 25);
            this.enteredletters.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "entered letters:";
            // 
            // btnpredict
            // 
            this.btnpredict.Location = new System.Drawing.Point(299, 26);
            this.btnpredict.Name = "btnpredict";
            this.btnpredict.Size = new System.Drawing.Size(136, 41);
            this.btnpredict.TabIndex = 3;
            this.btnpredict.Text = "Predict";
            this.btnpredict.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 30);
            this.textBox2.TabIndex = 2;
            // 
            // btn_letterenter
            // 
            this.btn_letterenter.Location = new System.Drawing.Point(86, 26);
            this.btn_letterenter.Name = "btn_letterenter";
            this.btn_letterenter.Size = new System.Drawing.Size(127, 41);
            this.btn_letterenter.TabIndex = 1;
            this.btn_letterenter.Text = "letter enter";
            this.btn_letterenter.UseVisualStyleBackColor = true;
            this.btn_letterenter.Click += new System.EventHandler(this.btn_letterenter_Click);
            // 
            // txt_letter
            // 
            this.txt_letter.Location = new System.Drawing.Point(6, 32);
            this.txt_letter.Name = "txt_letter";
            this.txt_letter.Size = new System.Drawing.Size(74, 30);
            this.txt_letter.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(338, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(448, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1079, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpgame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpgame;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_letterenter;
        private System.Windows.Forms.TextBox txt_letter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label yourremainingentitlement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label enteredletters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpredict;
    }
}

