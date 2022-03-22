namespace Lab_final_Result_system
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
            this.ID_BOX = new System.Windows.Forms.ListBox();
            this.NAME_BOX = new System.Windows.Forms.ListBox();
            this.PERCENTAGE_BOX = new System.Windows.Forms.ListBox();
            this.GRADE_BOX = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Search_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Search_Button = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Attendance = new System.Windows.Forms.Label();
            this.Quiz1 = new System.Windows.Forms.Label();
            this.Quiz2 = new System.Windows.Forms.Label();
            this.Quiz3 = new System.Windows.Forms.Label();
            this.Quiz4 = new System.Windows.Forms.Label();
            this.Mid = new System.Windows.Forms.Label();
            this.Final = new System.Windows.Forms.Label();
            this.Viva = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Percentage = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_BOX
            // 
            this.ID_BOX.FormattingEnabled = true;
            this.ID_BOX.ItemHeight = 16;
            this.ID_BOX.Location = new System.Drawing.Point(65, 72);
            this.ID_BOX.Name = "ID_BOX";
            this.ID_BOX.Size = new System.Drawing.Size(201, 356);
            this.ID_BOX.TabIndex = 0;
            // 
            // NAME_BOX
            // 
            this.NAME_BOX.FormattingEnabled = true;
            this.NAME_BOX.ItemHeight = 16;
            this.NAME_BOX.Location = new System.Drawing.Point(287, 72);
            this.NAME_BOX.Name = "NAME_BOX";
            this.NAME_BOX.Size = new System.Drawing.Size(226, 356);
            this.NAME_BOX.TabIndex = 1;
            // 
            // PERCENTAGE_BOX
            // 
            this.PERCENTAGE_BOX.FormattingEnabled = true;
            this.PERCENTAGE_BOX.ItemHeight = 16;
            this.PERCENTAGE_BOX.Location = new System.Drawing.Point(560, 72);
            this.PERCENTAGE_BOX.Name = "PERCENTAGE_BOX";
            this.PERCENTAGE_BOX.Size = new System.Drawing.Size(154, 356);
            this.PERCENTAGE_BOX.TabIndex = 2;
            // 
            // GRADE_BOX
            // 
            this.GRADE_BOX.FormattingEnabled = true;
            this.GRADE_BOX.ItemHeight = 16;
            this.GRADE_BOX.Location = new System.Drawing.Point(775, 72);
            this.GRADE_BOX.Name = "GRADE_BOX";
            this.GRADE_BOX.Size = new System.Drawing.Size(154, 356);
            this.GRADE_BOX.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Percentage ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grade";
            // 
            // Search_Box
            // 
            this.Search_Box.Location = new System.Drawing.Point(1179, 55);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.Size = new System.Drawing.Size(100, 22);
            this.Search_Box.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1176, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Search By Id";
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(1179, 98);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(75, 23);
            this.Search_Button.TabIndex = 10;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(1034, 169);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(75, 16);
            this.a.TabIndex = 11;
            this.a.Text = "Attendance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1032, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quiz 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1032, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quiz 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1032, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Quiz 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1032, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Quiz 4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1032, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mid";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1032, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Final";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1032, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Viva";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1032, 437);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Totasl (Out of 300)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1032, 475);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Percentage";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1032, 499);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 16);
            this.label15.TabIndex = 21;
            this.label15.Text = "Grade";
            // 
            // Attendance
            // 
            this.Attendance.AutoSize = true;
            this.Attendance.Location = new System.Drawing.Point(1144, 169);
            this.Attendance.Name = "Attendance";
            this.Attendance.Size = new System.Drawing.Size(75, 16);
            this.Attendance.TabIndex = 22;
            this.Attendance.Text = "Attendance";
            // 
            // Quiz1
            // 
            this.Quiz1.AutoSize = true;
            this.Quiz1.Location = new System.Drawing.Point(1143, 208);
            this.Quiz1.Name = "Quiz1";
            this.Quiz1.Size = new System.Drawing.Size(43, 16);
            this.Quiz1.TabIndex = 23;
            this.Quiz1.Text = "Quiz 1";
            // 
            // Quiz2
            // 
            this.Quiz2.AutoSize = true;
            this.Quiz2.Location = new System.Drawing.Point(1143, 240);
            this.Quiz2.Name = "Quiz2";
            this.Quiz2.Size = new System.Drawing.Size(43, 16);
            this.Quiz2.TabIndex = 24;
            this.Quiz2.Text = "Quiz 1";
            // 
            // Quiz3
            // 
            this.Quiz3.AutoSize = true;
            this.Quiz3.Location = new System.Drawing.Point(1143, 271);
            this.Quiz3.Name = "Quiz3";
            this.Quiz3.Size = new System.Drawing.Size(43, 16);
            this.Quiz3.TabIndex = 25;
            this.Quiz3.Text = "Quiz 1";
            // 
            // Quiz4
            // 
            this.Quiz4.AutoSize = true;
            this.Quiz4.Location = new System.Drawing.Point(1143, 308);
            this.Quiz4.Name = "Quiz4";
            this.Quiz4.Size = new System.Drawing.Size(43, 16);
            this.Quiz4.TabIndex = 26;
            this.Quiz4.Text = "Quiz 1";
            // 
            // Mid
            // 
            this.Mid.AutoSize = true;
            this.Mid.Location = new System.Drawing.Point(1143, 342);
            this.Mid.Name = "Mid";
            this.Mid.Size = new System.Drawing.Size(43, 16);
            this.Mid.TabIndex = 27;
            this.Mid.Text = "Quiz 1";
            // 
            // Final
            // 
            this.Final.AutoSize = true;
            this.Final.Location = new System.Drawing.Point(1143, 376);
            this.Final.Name = "Final";
            this.Final.Size = new System.Drawing.Size(43, 16);
            this.Final.TabIndex = 28;
            this.Final.Text = "Quiz 1";
            // 
            // Viva
            // 
            this.Viva.AutoSize = true;
            this.Viva.Location = new System.Drawing.Point(1143, 406);
            this.Viva.Name = "Viva";
            this.Viva.Size = new System.Drawing.Size(43, 16);
            this.Viva.TabIndex = 29;
            this.Viva.Text = "Quiz 1";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(1175, 437);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(43, 16);
            this.Total.TabIndex = 30;
            this.Total.Text = "Quiz 1";
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Location = new System.Drawing.Point(1176, 475);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(43, 16);
            this.Percentage.TabIndex = 31;
            this.Percentage.Text = "Quiz 1";
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Location = new System.Drawing.Point(1175, 491);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(43, 16);
            this.Grade.TabIndex = 32;
            this.Grade.Text = "Quiz 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 560);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Viva);
            this.Controls.Add(this.Final);
            this.Controls.Add(this.Mid);
            this.Controls.Add(this.Quiz4);
            this.Controls.Add(this.Quiz3);
            this.Controls.Add(this.Quiz2);
            this.Controls.Add(this.Quiz1);
            this.Controls.Add(this.Attendance);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.a);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Search_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GRADE_BOX);
            this.Controls.Add(this.PERCENTAGE_BOX);
            this.Controls.Add(this.NAME_BOX);
            this.Controls.Add(this.ID_BOX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ID_BOX;
        private System.Windows.Forms.ListBox NAME_BOX;
        private System.Windows.Forms.ListBox PERCENTAGE_BOX;
        private System.Windows.Forms.ListBox GRADE_BOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Search_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Attendance;
        private System.Windows.Forms.Label Quiz1;
        private System.Windows.Forms.Label Quiz2;
        private System.Windows.Forms.Label Quiz3;
        private System.Windows.Forms.Label Quiz4;
        private System.Windows.Forms.Label Mid;
        private System.Windows.Forms.Label Final;
        private System.Windows.Forms.Label Viva;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Percentage;
        private System.Windows.Forms.Label Grade;
    }
}

