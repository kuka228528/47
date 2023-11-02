
namespace проект2
{
    partial class PersonalAreaAdmin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalAreaAdmin));
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Maroon;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(299, 378);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(199, 60);
			this.button2.TabIndex = 46;
			this.button2.Text = "Ок";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(12, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(436, 25);
			this.label1.TabIndex = 47;
			this.label1.Text = "Вы можете обратиться в отделение банка";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(12, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(580, 25);
			this.label2.TabIndex = 48;
			this.label2.Text = "Мы в телеграмме: https://t.me/alfabankbot?start=botostore";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(12, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(303, 25);
			this.label3.TabIndex = 49;
			this.label3.Text = "Наш сайт:  https://alfabank.ru/";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(12, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(323, 25);
			this.label4.TabIndex = 50;
			this.label4.Text = "Мы по телефону: 79800015341";
			// 
			// PersonalAreaAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PersonalAreaAdmin";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}