using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System_Extended
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        int room_no = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Order_status_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < HMS.USER.Count; i++)

            {
                if(HMS.USER[i].User_ID == Book_User_ID.Text)
                {
                    HMS.USER[i].Room_Quantity = Convert.ToInt32(Quantity_Box.Text);
                    HMS.USER[i].Room_Type = Room_Choice_Box.Text;
                    HMS.USER[i].Date = Convert.ToInt32(Departure_Date_Box.Text) - Convert.ToInt32(Entry_Date_Box.Text);
                    HMS.USER[i].Booking_ID = cnt; cnt++;
                    HMS.USER[i].Status = "Pending";
                    if(Room_Choice_Box.Text == "Single")
                    {
                        HMS.USER[i].Amount = HMS.USER[i].Room_Quantity * 100 * HMS.USER[i].Date;
                    }
                    else if(Room_Choice_Box.Text == "Double")
                    {
                        HMS.USER[i].Amount = HMS.USER[i].Room_Quantity * 200 * HMS.USER[i].Date;
                    }
                    else if(Room_Choice_Box.Text == "Suite")
                    {
                        HMS.USER[i].Amount = HMS.USER[i].Room_Quantity * 300 * HMS.USER[i].Date;
                    }
                    else if (Room_Choice_Box.Text == "Deluxe")
                    {
                        HMS.USER[i].Amount = HMS.USER[i].Room_Quantity * 400 * HMS.USER[i].Date;
                    }
                    MessageBox.Show("Order Placed. ID = " + HMS.USER[i].User_ID);
                    // quantity, room type, date, booking id, amount = $
                    break;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < HMS.USER.Count; i++)
            {
                if (HMS.USER[i].User_ID == Owner_Booking_ID_Box.Text)
                {
                    HMS.USER[i].Status = Owner_Booking_Status_Box.Text;
                    HMS.USER[i].Room_No = room_no; room_no++;

                    HMS.Cost += HMS.USER[i].Amount;
                    MessageBox.Show("Status set of ID = " + HMS.USER[i].User_ID);
                    //Status, Room no
                    break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            User dum = new User();
            dum.User_ID = create_User_Id.Text;
            dum.Name = Create_Name.Text;
            dum.Contact_No = Create_Contact_No.Text;
            dum.Adress = Create_Adress.Text;

            HMS.USER.Add(dum);
            MessageBox.Show("USER" + " " + dum.User_ID + " " + "ADDED");
            
        }

        private void Order_Id_Owner_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List_Box.Items.Clear();
            //List_Box.Items.Add("Booking Id\t\tRoom Type\tRoom Quantity\tStatus\t\tAmount");
            for(int i = 0; i < HMS.USER.Count; i++)
            {
                Show_Bal.Text = Convert.ToString(HMS.Cost); 
                //string s = "HMS.USER.[i]";
                List_Box.Items.Add(Convert.ToString(HMS.USER[i].Booking_ID) + "\t" + HMS.USER[i].Room_Type + "\t" + /* Convert.ToString(HMS.USER[i].Room_No)
                    + */ "\t" + HMS.USER[i].Room_Quantity + "\t" + HMS.USER[i].Status + "\t\t" + Convert.ToString(HMS.USER[i].Amount) );
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < HMS.USER.Count; i++)
            {
                if(HMS.USER[i].User_ID == Show_Order_ID_Box.Text)
                {
                    show_adress.Text = HMS.USER[i].Adress;
                    show_amount.Text = Convert.ToString(HMS.USER[i].Amount);
                    show_user_name.Text = HMS.USER[i].Name;
                    show_status.Text = HMS.USER[i].Status;

                    break;
                }
            }
        }
    }
}
