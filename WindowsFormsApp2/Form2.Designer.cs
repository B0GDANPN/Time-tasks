
namespace WindowsFormsApp2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_InitDate = new System.Windows.Forms.DateTimePicker();
            this.ocTimeNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.durratNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ocTimeNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durratNumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(129, 9);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Name.Size = new System.Drawing.Size(277, 20);
            this.tb_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(277, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата начала:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.MaximumSize = new System.Drawing.Size(95, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Оценочное время( в часах):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.MaximumSize = new System.Drawing.Size(113, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Продолжительность( в часах):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_InitDate
            // 
            this.dtp_InitDate.Location = new System.Drawing.Point(129, 61);
            this.dtp_InitDate.Name = "dtp_InitDate";
            this.dtp_InitDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_InitDate.TabIndex = 11;
            // 
            // ocTimeNumericUpDown1
            // 
            this.ocTimeNumericUpDown1.Location = new System.Drawing.Point(129, 93);
            this.ocTimeNumericUpDown1.Name = "ocTimeNumericUpDown1";
            this.ocTimeNumericUpDown1.Size = new System.Drawing.Size(277, 20);
            this.ocTimeNumericUpDown1.TabIndex = 12;
            // 
            // durratNumericUpDown2
            // 
            this.durratNumericUpDown2.Location = new System.Drawing.Point(129, 122);
            this.durratNumericUpDown2.Name = "durratNumericUpDown2";
            this.durratNumericUpDown2.Size = new System.Drawing.Size(277, 20);
            this.durratNumericUpDown2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "От кого:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Комментарий:";
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(129, 162);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(277, 20);
            this.fromBox.TabIndex = 16;
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(129, 240);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(277, 56);
            this.commentBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Кому:";
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(129, 188);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(277, 20);
            this.toBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Где разместить:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(129, 214);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(277, 20);
            this.pathBox.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 371);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.durratNumericUpDown2);
            this.Controls.Add(this.ocTimeNumericUpDown1);
            this.Controls.Add(this.dtp_InitDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.ocTimeNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durratNumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_InitDate;
        private System.Windows.Forms.NumericUpDown ocTimeNumericUpDown1;
        private System.Windows.Forms.NumericUpDown durratNumericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pathBox;
    }
}