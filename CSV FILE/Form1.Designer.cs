namespace CSV_FILE
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
            this.Search_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Name_Box = new System.Windows.Forms.Label();
            this.Id_Box = new System.Windows.Forms.Label();
            this.Adress_Box = new System.Windows.Forms.Label();
            this.Hiring_Date_Box = new System.Windows.Forms.Label();
            this.Salary_Box = new System.Windows.Forms.Label();
            this.List_box = new System.Windows.Forms.ListBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search_Box
            // 
            this.Search_Box.Location = new System.Drawing.Point(496, 71);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.Size = new System.Drawing.Size(100, 22);
            this.Search_Box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hiring Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salary";
            // 
            // Name_Box
            // 
            this.Name_Box.AutoSize = true;
            this.Name_Box.Location = new System.Drawing.Point(577, 126);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(44, 16);
            this.Name_Box.TabIndex = 6;
            this.Name_Box.Text = "label6";
            // 
            // Id_Box
            // 
            this.Id_Box.AutoSize = true;
            this.Id_Box.Location = new System.Drawing.Point(577, 161);
            this.Id_Box.Name = "Id_Box";
            this.Id_Box.Size = new System.Drawing.Size(44, 16);
            this.Id_Box.TabIndex = 7;
            this.Id_Box.Text = "label7";
            // 
            // Adress_Box
            // 
            this.Adress_Box.AutoSize = true;
            this.Adress_Box.Location = new System.Drawing.Point(577, 200);
            this.Adress_Box.Name = "Adress_Box";
            this.Adress_Box.Size = new System.Drawing.Size(44, 16);
            this.Adress_Box.TabIndex = 8;
            this.Adress_Box.Text = "label8";
            // 
            // Hiring_Date_Box
            // 
            this.Hiring_Date_Box.AutoSize = true;
            this.Hiring_Date_Box.Location = new System.Drawing.Point(577, 236);
            this.Hiring_Date_Box.Name = "Hiring_Date_Box";
            this.Hiring_Date_Box.Size = new System.Drawing.Size(44, 16);
            this.Hiring_Date_Box.TabIndex = 9;
            this.Hiring_Date_Box.Text = "label9";
            // 
            // Salary_Box
            // 
            this.Salary_Box.AutoSize = true;
            this.Salary_Box.Location = new System.Drawing.Point(577, 272);
            this.Salary_Box.Name = "Salary_Box";
            this.Salary_Box.Size = new System.Drawing.Size(51, 16);
            this.Salary_Box.TabIndex = 10;
            this.Salary_Box.Text = "label10";
            // 
            // List_box
            // 
            this.List_box.FormattingEnabled = true;
            this.List_box.ItemHeight = 16;
            this.List_box.Location = new System.Drawing.Point(12, 80);
            this.List_box.Name = "List_box";
            this.List_box.Size = new System.Drawing.Size(395, 324);
            this.List_box.TabIndex = 11;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(496, 321);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(75, 23);
            this.Search_Button.TabIndex = 12;
            this.Search_Button.Text = "SEACH";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.List_box);
            this.Controls.Add(this.Salary_Box);
            this.Controls.Add(this.Hiring_Date_Box);
            this.Controls.Add(this.Adress_Box);
            this.Controls.Add(this.Id_Box);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Name_Box;
        private System.Windows.Forms.Label Id_Box;
        private System.Windows.Forms.Label Adress_Box;
        private System.Windows.Forms.Label Hiring_Date_Box;
        private System.Windows.Forms.Label Salary_Box;
        private System.Windows.Forms.ListBox List_box;
        private System.Windows.Forms.Button Search_Button;
    }
}

