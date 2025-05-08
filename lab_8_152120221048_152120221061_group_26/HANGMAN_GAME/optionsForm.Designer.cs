namespace HANGMAN_GAME
{
    partial class optionsForm
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
            this.kategoriComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kolayBtn = new System.Windows.Forms.RadioButton();
            this.ortaBtn = new System.Windows.Forms.RadioButton();
            this.zorBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.onaylaBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSure = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxResimTuru = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSure)).BeginInit();
            this.SuspendLayout();
            // 
            // kategoriComboBox
            // 
            this.kategoriComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategoriComboBox.FormattingEnabled = true;
            this.kategoriComboBox.Location = new System.Drawing.Point(31, 132);
            this.kategoriComboBox.Name = "kategoriComboBox";
            this.kategoriComboBox.Size = new System.Drawing.Size(225, 39);
            this.kategoriComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(360, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zorluk Seviyesi";
            // 
            // kolayBtn
            // 
            this.kolayBtn.AutoSize = true;
            this.kolayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolayBtn.Location = new System.Drawing.Point(6, 21);
            this.kolayBtn.Name = "kolayBtn";
            this.kolayBtn.Size = new System.Drawing.Size(83, 29);
            this.kolayBtn.TabIndex = 3;
            this.kolayBtn.TabStop = true;
            this.kolayBtn.Text = "Kolay";
            this.kolayBtn.UseVisualStyleBackColor = true;
            // 
            // ortaBtn
            // 
            this.ortaBtn.AutoSize = true;
            this.ortaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ortaBtn.Location = new System.Drawing.Point(6, 78);
            this.ortaBtn.Name = "ortaBtn";
            this.ortaBtn.Size = new System.Drawing.Size(71, 29);
            this.ortaBtn.TabIndex = 4;
            this.ortaBtn.TabStop = true;
            this.ortaBtn.Text = "Orta";
            this.ortaBtn.UseVisualStyleBackColor = true;
            // 
            // zorBtn
            // 
            this.zorBtn.AutoSize = true;
            this.zorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zorBtn.Location = new System.Drawing.Point(6, 134);
            this.zorBtn.Name = "zorBtn";
            this.zorBtn.Size = new System.Drawing.Size(62, 29);
            this.zorBtn.TabIndex = 5;
            this.zorBtn.TabStop = true;
            this.zorBtn.Text = "Zor";
            this.zorBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zorBtn);
            this.groupBox1.Controls.Add(this.ortaBtn);
            this.groupBox1.Controls.Add(this.kolayBtn);
            this.groupBox1.Location = new System.Drawing.Point(367, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 169);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // onaylaBtn
            // 
            this.onaylaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylaBtn.Location = new System.Drawing.Point(403, 388);
            this.onaylaBtn.Name = "onaylaBtn";
            this.onaylaBtn.Size = new System.Drawing.Size(196, 67);
            this.onaylaBtn.TabIndex = 7;
            this.onaylaBtn.Text = "Onayla";
            this.onaylaBtn.UseVisualStyleBackColor = true;
            this.onaylaBtn.Click += new System.EventHandler(this.onaylaBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(713, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Süre Seçimi";
            // 
            // numericUpDownSure
            // 
            this.numericUpDownSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownSure.Location = new System.Drawing.Point(720, 133);
            this.numericUpDownSure.Name = "numericUpDownSure";
            this.numericUpDownSure.Size = new System.Drawing.Size(284, 38);
            this.numericUpDownSure.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(713, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resim Seçimi";
            // 
            // comboBoxResimTuru
            // 
            this.comboBoxResimTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxResimTuru.FormattingEnabled = true;
            this.comboBoxResimTuru.Location = new System.Drawing.Point(720, 263);
            this.comboBoxResimTuru.Name = "comboBoxResimTuru";
            this.comboBoxResimTuru.Size = new System.Drawing.Size(284, 39);
            this.comboBoxResimTuru.TabIndex = 11;
            // 
            // optionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 596);
            this.Controls.Add(this.comboBoxResimTuru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.onaylaBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kategoriComboBox);
            this.Name = "optionsForm";
            this.Text = "optionsForm";
            this.Load += new System.EventHandler(this.optionsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox kategoriComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton kolayBtn;
        private System.Windows.Forms.RadioButton ortaBtn;
        private System.Windows.Forms.RadioButton zorBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button onaylaBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxResimTuru;
    }
}