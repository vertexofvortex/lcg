namespace LCG
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Value_a = new System.Windows.Forms.TextBox();
            this.Value_b = new System.Windows.Forms.TextBox();
            this.Value_c = new System.Windows.Forms.TextBox();
            this.Value_k = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PeriodBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).BeginInit();
            this.SuspendLayout();
            // 
            // Value_a
            // 
            this.Value_a.Location = new System.Drawing.Point(184, 12);
            this.Value_a.Name = "Value_a";
            this.Value_a.Size = new System.Drawing.Size(100, 20);
            this.Value_a.TabIndex = 0;
            this.Value_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Value_a.TextChanged += new System.EventHandler(this.Value_a_TextChanged);
            // 
            // Value_b
            // 
            this.Value_b.Location = new System.Drawing.Point(184, 38);
            this.Value_b.Name = "Value_b";
            this.Value_b.Size = new System.Drawing.Size(100, 20);
            this.Value_b.TabIndex = 1;
            this.Value_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Value_b.TextChanged += new System.EventHandler(this.Value_b_TextChanged);
            // 
            // Value_c
            // 
            this.Value_c.Location = new System.Drawing.Point(184, 64);
            this.Value_c.Name = "Value_c";
            this.Value_c.Size = new System.Drawing.Size(100, 20);
            this.Value_c.TabIndex = 2;
            this.Value_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Value_c.TextChanged += new System.EventHandler(this.Value_c_TextChanged);
            // 
            // Value_k
            // 
            this.Value_k.Location = new System.Drawing.Point(184, 90);
            this.Value_k.Name = "Value_k";
            this.Value_k.Size = new System.Drawing.Size(100, 20);
            this.Value_k.TabIndex = 3;
            this.Value_k.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Value_k.TextChanged += new System.EventHandler(this.Value_k_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Значение a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Значение b";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Значение c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Значение предыдущего k";
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(12, 116);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(272, 35);
            this.Generate.TabIndex = 8;
            this.Generate.Text = "Сгенерировать последовательность";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 183);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Result.Size = new System.Drawing.Size(272, 209);
            this.Result.TabIndex = 9;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "© vertex labs";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(231, 157);
            this.Count.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(53, 20);
            this.Count.TabIndex = 11;
            this.Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count.ValueChanged += new System.EventHandler(this.Count_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Количество генерируемых чисел";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Период последовательности";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // PeriodBox
            // 
            this.PeriodBox.Location = new System.Drawing.Point(184, 398);
            this.PeriodBox.Multiline = true;
            this.PeriodBox.Name = "PeriodBox";
            this.PeriodBox.ReadOnly = true;
            this.PeriodBox.Size = new System.Drawing.Size(100, 20);
            this.PeriodBox.TabIndex = 14;
            this.PeriodBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PeriodBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 450);
            this.Controls.Add(this.PeriodBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Value_k);
            this.Controls.Add(this.Value_c);
            this.Controls.Add(this.Value_b);
            this.Controls.Add(this.Value_a);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ЛКГПСЧ 3000";
            ((System.ComponentModel.ISupportInitialize)(this.Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Value_a;
        private System.Windows.Forms.TextBox Value_b;
        private System.Windows.Forms.TextBox Value_c;
        private System.Windows.Forms.TextBox Value_k;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Count;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PeriodBox;
    }
}

