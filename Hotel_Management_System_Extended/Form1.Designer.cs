namespace Hotel_Management_System_Extended
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
            this.button1 = new System.Windows.Forms.Button();
            this.Owner_Booking_Status_Box = new System.Windows.Forms.ComboBox();
            this.Owner_Booking_ID_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.create_User_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Create_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Create_Adress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Create_Contact_No = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Book_User_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Room_Choice_Box = new System.Windows.Forms.ComboBox();
            this.Quantity_Box = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Entry_Date_Box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Departure_Date_Box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.List_Box = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Show_Order_ID_Box = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.show_amount = new System.Windows.Forms.Label();
            this.show_room_number = new System.Windows.Forms.Label();
            this.show_status = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.show_adress = new System.Windows.Forms.Label();
            this.show_user_name = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.Show_Bal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "SET STATUS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Owner_Booking_Status_Box
            // 
            this.Owner_Booking_Status_Box.FormattingEnabled = true;
            this.Owner_Booking_Status_Box.Items.AddRange(new object[] {
            "Pending",
            "Confirmed"});
            this.Owner_Booking_Status_Box.Location = new System.Drawing.Point(223, 92);
            this.Owner_Booking_Status_Box.Name = "Owner_Booking_Status_Box";
            this.Owner_Booking_Status_Box.Size = new System.Drawing.Size(121, 24);
            this.Owner_Booking_Status_Box.TabIndex = 8;
            this.Owner_Booking_Status_Box.SelectedIndexChanged += new System.EventHandler(this.Order_status_box_SelectedIndexChanged);
            // 
            // Owner_Booking_ID_Box
            // 
            this.Owner_Booking_ID_Box.Location = new System.Drawing.Point(117, 94);
            this.Owner_Booking_ID_Box.Name = "Owner_Booking_ID_Box";
            this.Owner_Booking_ID_Box.Size = new System.Drawing.Size(100, 22);
            this.Owner_Booking_ID_Box.TabIndex = 7;
            this.Owner_Booking_ID_Box.TextChanged += new System.EventHandler(this.Order_Id_Owner_box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Booking ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Owner Section";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(956, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "User Section";
            // 
            // create_User_Id
            // 
            this.create_User_Id.Location = new System.Drawing.Point(749, 80);
            this.create_User_Id.Name = "create_User_Id";
            this.create_User_Id.Size = new System.Drawing.Size(100, 22);
            this.create_User_Id.TabIndex = 13;
            this.create_User_Id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "User ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Create_Name
            // 
            this.Create_Name.Location = new System.Drawing.Point(749, 128);
            this.Create_Name.Name = "Create_Name";
            this.Create_Name.Size = new System.Drawing.Size(100, 22);
            this.Create_Name.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Create_Adress
            // 
            this.Create_Adress.Location = new System.Drawing.Point(749, 224);
            this.Create_Adress.Name = "Create_Adress";
            this.Create_Adress.Size = new System.Drawing.Size(100, 22);
            this.Create_Adress.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Adress";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Create_Contact_No
            // 
            this.Create_Contact_No.Location = new System.Drawing.Point(749, 176);
            this.Create_Contact_No.Name = "Create_Contact_No";
            this.Create_Contact_No.Size = new System.Drawing.Size(100, 22);
            this.Create_Contact_No.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Contact No";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Book_User_ID
            // 
            this.Book_User_ID.Location = new System.Drawing.Point(1054, 77);
            this.Book_User_ID.Name = "Book_User_ID";
            this.Book_User_ID.Size = new System.Drawing.Size(100, 22);
            this.Book_User_ID.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(965, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "User ID";
            // 
            // Room_Choice_Box
            // 
            this.Room_Choice_Box.FormattingEnabled = true;
            this.Room_Choice_Box.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite",
            "Deluxe"});
            this.Room_Choice_Box.Location = new System.Drawing.Point(1054, 120);
            this.Room_Choice_Box.Name = "Room_Choice_Box";
            this.Room_Choice_Box.Size = new System.Drawing.Size(121, 24);
            this.Room_Choice_Box.TabIndex = 23;
            // 
            // Quantity_Box
            // 
            this.Quantity_Box.FormattingEnabled = true;
            this.Quantity_Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Quantity_Box.Location = new System.Drawing.Point(1054, 168);
            this.Quantity_Box.Name = "Quantity_Box";
            this.Quantity_Box.Size = new System.Drawing.Size(121, 24);
            this.Quantity_Box.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(953, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Room choice";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(956, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Quantity";
            // 
            // Entry_Date_Box
            // 
            this.Entry_Date_Box.Location = new System.Drawing.Point(1054, 211);
            this.Entry_Date_Box.Name = "Entry_Date_Box";
            this.Entry_Date_Box.Size = new System.Drawing.Size(100, 22);
            this.Entry_Date_Box.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(965, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Entry Date";
            // 
            // Departure_Date_Box
            // 
            this.Departure_Date_Box.Location = new System.Drawing.Point(1054, 257);
            this.Departure_Date_Box.Name = "Departure_Date_Box";
            this.Departure_Date_Box.Size = new System.Drawing.Size(100, 22);
            this.Departure_Date_Box.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(941, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Departure Date";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1237, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 25);
            this.button2.TabIndex = 30;
            this.button2.Text = "Place Booking";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(115, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "Current Balance";
            // 
            // List_Box
            // 
            this.List_Box.FormattingEnabled = true;
            this.List_Box.ItemHeight = 16;
            this.List_Box.Location = new System.Drawing.Point(223, 335);
            this.List_Box.Name = "List_Box";
            this.List_Box.Size = new System.Drawing.Size(510, 196);
            this.List_Box.TabIndex = 32;
            this.List_Box.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 25);
            this.button3.TabIndex = 33;
            this.button3.Text = "Show Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Show_Order_ID_Box
            // 
            this.Show_Order_ID_Box.Location = new System.Drawing.Point(872, 345);
            this.Show_Order_ID_Box.Name = "Show_Order_ID_Box";
            this.Show_Order_ID_Box.Size = new System.Drawing.Size(100, 22);
            this.Show_Order_ID_Box.TabIndex = 35;
            this.Show_Order_ID_Box.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(768, 348);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 34;
            this.label14.Text = "Booking ID";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(768, 435);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 16);
            this.label15.TabIndex = 38;
            this.label15.Text = "Amount";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(768, 401);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 16);
            this.label16.TabIndex = 37;
            this.label16.Text = "--";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(768, 375);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 16);
            this.label17.TabIndex = 36;
            this.label17.Text = "Status";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // show_amount
            // 
            this.show_amount.AutoSize = true;
            this.show_amount.Location = new System.Drawing.Point(869, 435);
            this.show_amount.Name = "show_amount";
            this.show_amount.Size = new System.Drawing.Size(52, 16);
            this.show_amount.TabIndex = 41;
            this.show_amount.Text = "Amount";
            // 
            // show_room_number
            // 
            this.show_room_number.AutoSize = true;
            this.show_room_number.Location = new System.Drawing.Point(869, 401);
            this.show_room_number.Name = "show_room_number";
            this.show_room_number.Size = new System.Drawing.Size(15, 16);
            this.show_room_number.TabIndex = 40;
            this.show_room_number.Text = "--";
            // 
            // show_status
            // 
            this.show_status.AutoSize = true;
            this.show_status.Location = new System.Drawing.Point(869, 375);
            this.show_status.Name = "show_status";
            this.show_status.Size = new System.Drawing.Size(44, 16);
            this.show_status.TabIndex = 39;
            this.show_status.Text = "Status";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(904, 500);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 41);
            this.button4.TabIndex = 42;
            this.button4.Text = "Show Order Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1070, 351);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 16);
            this.label21.TabIndex = 43;
            this.label21.Text = "User Name";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1070, 392);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 16);
            this.label22.TabIndex = 44;
            this.label22.Text = "Adress";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // show_adress
            // 
            this.show_adress.AutoSize = true;
            this.show_adress.Location = new System.Drawing.Point(1162, 392);
            this.show_adress.Name = "show_adress";
            this.show_adress.Size = new System.Drawing.Size(50, 16);
            this.show_adress.TabIndex = 46;
            this.show_adress.Text = "Adress";
            // 
            // show_user_name
            // 
            this.show_user_name.AutoSize = true;
            this.show_user_name.Location = new System.Drawing.Point(1162, 351);
            this.show_user_name.Name = "show_user_name";
            this.show_user_name.Size = new System.Drawing.Size(76, 16);
            this.show_user_name.TabIndex = 45;
            this.show_user_name.Text = "User Name";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(749, 257);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 25);
            this.button5.TabIndex = 47;
            this.button5.Text = "Add User";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Show_Bal
            // 
            this.Show_Bal.AutoSize = true;
            this.Show_Bal.Location = new System.Drawing.Point(247, 293);
            this.Show_Bal.Name = "Show_Bal";
            this.Show_Bal.Size = new System.Drawing.Size(63, 16);
            this.Show_Bal.TabIndex = 48;
            this.Show_Bal.Text = "Show Bal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 562);
            this.Controls.Add(this.Show_Bal);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.show_adress);
            this.Controls.Add(this.show_user_name);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.show_amount);
            this.Controls.Add(this.show_room_number);
            this.Controls.Add(this.show_status);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Show_Order_ID_Box);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.List_Box);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Departure_Date_Box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Entry_Date_Box);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Quantity_Box);
            this.Controls.Add(this.Room_Choice_Box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Book_User_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Create_Adress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Create_Contact_No);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Create_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.create_User_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Owner_Booking_Status_Box);
            this.Controls.Add(this.Owner_Booking_ID_Box);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Owner_Booking_Status_Box;
        private System.Windows.Forms.TextBox Owner_Booking_ID_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox create_User_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Create_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Create_Adress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Create_Contact_No;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Book_User_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Room_Choice_Box;
        private System.Windows.Forms.ComboBox Quantity_Box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Entry_Date_Box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Departure_Date_Box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox List_Box;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Show_Order_ID_Box;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label show_amount;
        private System.Windows.Forms.Label show_room_number;
        private System.Windows.Forms.Label show_status;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label show_adress;
        private System.Windows.Forms.Label show_user_name;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Show_Bal;
    }
}

