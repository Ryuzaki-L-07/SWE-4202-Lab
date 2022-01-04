namespace Course_Registration_LMS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Teacher_Name_Box = new System.Windows.Forms.TextBox();
            this.Teacher_Type_Box = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Course_Semester_Box = new System.Windows.Forms.ComboBox();
            this.Course_Teacher_Box = new System.Windows.Forms.ComboBox();
            this.Course_Title_Box = new System.Windows.Forms.TextBox();
            this.Student_Name_Box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Student_Semester_Box = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Course_Type_Box = new System.Windows.Forms.ComboBox();
            this.Student_Course_Box = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Teacher_Button = new System.Windows.Forms.Button();
            this.Course_Button = new System.Windows.Forms.Button();
            this.Student_Button = new System.Windows.Forms.Button();
            this.Student_List_Box = new System.Windows.Forms.ListBox();
            this.Teacher_List_Box = new System.Windows.Forms.ListBox();
            this.Student_Info_Button = new System.Windows.Forms.Button();
            this.Teacher_Info_Button = new System.Windows.Forms.Button();
            this.Student_Info_Box = new System.Windows.Forms.ComboBox();
            this.Teacher_Info_Box = new System.Windows.Forms.ComboBox();
            this.Course_Code_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teacher Type";
            // 
            // Teacher_Name_Box
            // 
            this.Teacher_Name_Box.Location = new System.Drawing.Point(130, 91);
            this.Teacher_Name_Box.Name = "Teacher_Name_Box";
            this.Teacher_Name_Box.Size = new System.Drawing.Size(100, 22);
            this.Teacher_Name_Box.TabIndex = 5;
            // 
            // Teacher_Type_Box
            // 
            this.Teacher_Type_Box.FormattingEnabled = true;
            this.Teacher_Type_Box.Items.AddRange(new object[] {
            "Lecturer",
            "Professor"});
            this.Teacher_Type_Box.Location = new System.Drawing.Point(130, 139);
            this.Teacher_Type_Box.Name = "Teacher_Type_Box";
            this.Teacher_Type_Box.Size = new System.Drawing.Size(121, 24);
            this.Teacher_Type_Box.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Course Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Course Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Semester";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Teacher";
            // 
            // Course_Semester_Box
            // 
            this.Course_Semester_Box.FormattingEnabled = true;
            this.Course_Semester_Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.Course_Semester_Box.Location = new System.Drawing.Point(437, 174);
            this.Course_Semester_Box.Name = "Course_Semester_Box";
            this.Course_Semester_Box.Size = new System.Drawing.Size(121, 24);
            this.Course_Semester_Box.TabIndex = 14;
            // 
            // Course_Teacher_Box
            // 
            this.Course_Teacher_Box.FormattingEnabled = true;
            this.Course_Teacher_Box.Location = new System.Drawing.Point(437, 212);
            this.Course_Teacher_Box.Name = "Course_Teacher_Box";
            this.Course_Teacher_Box.Size = new System.Drawing.Size(121, 24);
            this.Course_Teacher_Box.TabIndex = 15;
            // 
            // Course_Title_Box
            // 
            this.Course_Title_Box.Location = new System.Drawing.Point(437, 147);
            this.Course_Title_Box.Name = "Course_Title_Box";
            this.Course_Title_Box.Size = new System.Drawing.Size(100, 22);
            this.Course_Title_Box.TabIndex = 16;
            // 
            // Student_Name_Box
            // 
            this.Student_Name_Box.Location = new System.Drawing.Point(781, 85);
            this.Student_Name_Box.Name = "Student_Name_Box";
            this.Student_Name_Box.Size = new System.Drawing.Size(100, 22);
            this.Student_Name_Box.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(672, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Name";
            // 
            // Student_Semester_Box
            // 
            this.Student_Semester_Box.FormattingEnabled = true;
            this.Student_Semester_Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.Student_Semester_Box.Location = new System.Drawing.Point(781, 120);
            this.Student_Semester_Box.Name = "Student_Semester_Box";
            this.Student_Semester_Box.Size = new System.Drawing.Size(121, 24);
            this.Student_Semester_Box.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(672, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Course Type";
            // 
            // Course_Type_Box
            // 
            this.Course_Type_Box.FormattingEnabled = true;
            this.Course_Type_Box.Items.AddRange(new object[] {
            "Theory",
            "Lab"});
            this.Course_Type_Box.Location = new System.Drawing.Point(437, 112);
            this.Course_Type_Box.Name = "Course_Type_Box";
            this.Course_Type_Box.Size = new System.Drawing.Size(121, 24);
            this.Course_Type_Box.TabIndex = 13;
            // 
            // Student_Course_Box
            // 
            this.Student_Course_Box.FormattingEnabled = true;
            this.Student_Course_Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.Student_Course_Box.Location = new System.Drawing.Point(781, 161);
            this.Student_Course_Box.Name = "Student_Course_Box";
            this.Student_Course_Box.Size = new System.Drawing.Size(121, 24);
            this.Student_Course_Box.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(672, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Course";
            // 
            // Teacher_Button
            // 
            this.Teacher_Button.Location = new System.Drawing.Point(130, 191);
            this.Teacher_Button.Name = "Teacher_Button";
            this.Teacher_Button.Size = new System.Drawing.Size(75, 23);
            this.Teacher_Button.TabIndex = 23;
            this.Teacher_Button.Text = "Add";
            this.Teacher_Button.UseVisualStyleBackColor = true;
            this.Teacher_Button.Click += new System.EventHandler(this.Teacher_Button_Click);
            // 
            // Course_Button
            // 
            this.Course_Button.Location = new System.Drawing.Point(437, 258);
            this.Course_Button.Name = "Course_Button";
            this.Course_Button.Size = new System.Drawing.Size(75, 23);
            this.Course_Button.TabIndex = 24;
            this.Course_Button.Text = "Add";
            this.Course_Button.UseVisualStyleBackColor = true;
            this.Course_Button.Click += new System.EventHandler(this.Course_Button_Click);
            // 
            // Student_Button
            // 
            this.Student_Button.Location = new System.Drawing.Point(781, 212);
            this.Student_Button.Name = "Student_Button";
            this.Student_Button.Size = new System.Drawing.Size(75, 23);
            this.Student_Button.TabIndex = 25;
            this.Student_Button.Text = "Add";
            this.Student_Button.UseVisualStyleBackColor = true;
            this.Student_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Student_List_Box
            // 
            this.Student_List_Box.FormattingEnabled = true;
            this.Student_List_Box.ItemHeight = 16;
            this.Student_List_Box.Location = new System.Drawing.Point(85, 317);
            this.Student_List_Box.Name = "Student_List_Box";
            this.Student_List_Box.Size = new System.Drawing.Size(232, 148);
            this.Student_List_Box.TabIndex = 26;
            // 
            // Teacher_List_Box
            // 
            this.Teacher_List_Box.FormattingEnabled = true;
            this.Teacher_List_Box.ItemHeight = 16;
            this.Teacher_List_Box.Location = new System.Drawing.Point(781, 308);
            this.Teacher_List_Box.Name = "Teacher_List_Box";
            this.Teacher_List_Box.Size = new System.Drawing.Size(383, 132);
            this.Teacher_List_Box.TabIndex = 27;
            // 
            // Student_Info_Button
            // 
            this.Student_Info_Button.Location = new System.Drawing.Point(160, 468);
            this.Student_Info_Button.Name = "Student_Info_Button";
            this.Student_Info_Button.Size = new System.Drawing.Size(91, 52);
            this.Student_Info_Button.TabIndex = 28;
            this.Student_Info_Button.Text = "Show Student Info";
            this.Student_Info_Button.UseVisualStyleBackColor = true;
            this.Student_Info_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Teacher_Info_Button
            // 
            this.Teacher_Info_Button.Location = new System.Drawing.Point(899, 446);
            this.Teacher_Info_Button.Name = "Teacher_Info_Button";
            this.Teacher_Info_Button.Size = new System.Drawing.Size(91, 52);
            this.Teacher_Info_Button.TabIndex = 29;
            this.Teacher_Info_Button.Text = "Show Teacher Info";
            this.Teacher_Info_Button.UseVisualStyleBackColor = true;
            this.Teacher_Info_Button.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Student_Info_Box
            // 
            this.Student_Info_Box.FormattingEnabled = true;
            this.Student_Info_Box.Location = new System.Drawing.Point(323, 317);
            this.Student_Info_Box.Name = "Student_Info_Box";
            this.Student_Info_Box.Size = new System.Drawing.Size(121, 24);
            this.Student_Info_Box.TabIndex = 30;
            // 
            // Teacher_Info_Box
            // 
            this.Teacher_Info_Box.FormattingEnabled = true;
            this.Teacher_Info_Box.Location = new System.Drawing.Point(654, 308);
            this.Teacher_Info_Box.Name = "Teacher_Info_Box";
            this.Teacher_Info_Box.Size = new System.Drawing.Size(121, 24);
            this.Teacher_Info_Box.TabIndex = 31;
            // 
            // Course_Code_Box
            // 
            this.Course_Code_Box.Location = new System.Drawing.Point(437, 84);
            this.Course_Code_Box.Name = "Course_Code_Box";
            this.Course_Code_Box.Size = new System.Drawing.Size(100, 22);
            this.Course_Code_Box.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 532);
            this.Controls.Add(this.Course_Code_Box);
            this.Controls.Add(this.Teacher_Info_Box);
            this.Controls.Add(this.Student_Info_Box);
            this.Controls.Add(this.Teacher_Info_Button);
            this.Controls.Add(this.Student_Info_Button);
            this.Controls.Add(this.Teacher_List_Box);
            this.Controls.Add(this.Student_List_Box);
            this.Controls.Add(this.Student_Button);
            this.Controls.Add(this.Course_Button);
            this.Controls.Add(this.Teacher_Button);
            this.Controls.Add(this.Student_Course_Box);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Student_Semester_Box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Student_Name_Box);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Course_Title_Box);
            this.Controls.Add(this.Course_Teacher_Box);
            this.Controls.Add(this.Course_Semester_Box);
            this.Controls.Add(this.Course_Type_Box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Teacher_Type_Box);
            this.Controls.Add(this.Teacher_Name_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Teacher_Name_Box;
        private System.Windows.Forms.ComboBox Teacher_Type_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Course_Semester_Box;
        private System.Windows.Forms.ComboBox Course_Teacher_Box;
        private System.Windows.Forms.TextBox Course_Title_Box;
        private System.Windows.Forms.TextBox Student_Name_Box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Student_Semester_Box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Course_Type_Box;
        private System.Windows.Forms.ComboBox Student_Course_Box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Teacher_Button;
        private System.Windows.Forms.Button Course_Button;
        private System.Windows.Forms.Button Student_Button;
        private System.Windows.Forms.ListBox Student_List_Box;
        private System.Windows.Forms.ListBox Teacher_List_Box;
        private System.Windows.Forms.Button Student_Info_Button;
        private System.Windows.Forms.Button Teacher_Info_Button;
        private System.Windows.Forms.ComboBox Student_Info_Box;
        private System.Windows.Forms.ComboBox Teacher_Info_Box;
        private System.Windows.Forms.TextBox Course_Code_Box;
    }
}

