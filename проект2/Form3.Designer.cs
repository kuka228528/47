namespace проект2
{
	partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numstartcount = new System.Windows.Forms.NumericUpDown();
            this.numpercent = new System.Windows.Forms.NumericUpDown();
            this.numyears = new System.Windows.Forms.NumericUpDown();
            this.comboprocess = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numstartcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numyears)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчет";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Расчет стоимости";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(615, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Изначальная сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Процентная ставка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(395, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Срок ";
            // 
            // numstartcount
            // 
            this.numstartcount.DecimalPlaces = 2;
            this.numstartcount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numstartcount.Location = new System.Drawing.Point(263, 110);
            this.numstartcount.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numstartcount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numstartcount.Name = "numstartcount";
            this.numstartcount.Size = new System.Drawing.Size(299, 20);
            this.numstartcount.TabIndex = 11;
            this.numstartcount.ThousandsSeparator = true;
            this.numstartcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numpercent
            // 
            this.numpercent.DecimalPlaces = 2;
            this.numpercent.Location = new System.Drawing.Point(263, 155);
            this.numpercent.Name = "numpercent";
            this.numpercent.Size = new System.Drawing.Size(299, 20);
            this.numpercent.TabIndex = 12;
            this.numpercent.ThousandsSeparator = true;
            // 
            // numyears
            // 
            this.numyears.Location = new System.Drawing.Point(263, 201);
            this.numyears.Name = "numyears";
            this.numyears.Size = new System.Drawing.Size(299, 20);
            this.numyears.TabIndex = 13;
            // 
            // comboprocess
            // 
            this.comboprocess.FormattingEnabled = true;
            this.comboprocess.Items.AddRange(new object[] {
            "ежедневно",
            "ежемесячно",
            "ежегодно",
            "ежеквартально",
            "по полугодиям"});
            this.comboprocess.Location = new System.Drawing.Point(261, 248);
            this.comboprocess.Name = "comboprocess";
            this.comboprocess.Size = new System.Drawing.Size(301, 21);
            this.comboprocess.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Процесс начисления";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(261, 323);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(299, 20);
            this.total.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(24, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Итого";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboprocess);
            this.Controls.Add(this.numyears);
            this.Controls.Add(this.numpercent);
            this.Controls.Add(this.numstartcount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.numstartcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numyears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numstartcount;
        private System.Windows.Forms.NumericUpDown numpercent;
        private System.Windows.Forms.NumericUpDown numyears;
        private System.Windows.Forms.ComboBox comboprocess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label7;
    }
}