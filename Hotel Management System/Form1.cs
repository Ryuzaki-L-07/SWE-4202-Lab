using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Hotel_Management_System : Form
    {
        List <Single> SINGLE =  new List <Single>();
        List <Double> DOUBLE =  new List <Double>();
        public Hotel_Management_System()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Double_rent_button_Click(object sender, EventArgs e)
        {
            Double dummy = new Double();
            dummy.name = Double_name_box.Text;
            dummy.quantity = Convert.ToInt32(Double_quantity_box.Text);
            dummy.cost = 2500;
            dummy.TV = Convert.ToInt32(TV_box.Text); 
                dummy.cost += dummy.TV * 1000;
            dummy.Refrigerator = Convert.ToInt32(Refrigerator_box.Text);
                dummy.cost += dummy.Refrigerator * 500;
            dummy.Air_condition = Convert.ToInt32(Air_condition_box.Text);
                dummy.cost += dummy.Air_condition * 500;
            dummy.breakfast = Convert.ToInt32(Breakfast_box.Text);
                dummy.cost += dummy.breakfast * 500;
            dummy.Extra_Tv = Convert.ToInt32(Extra_TV_box.Text);
                dummy.cost += dummy.Extra_Tv * 1000;

                dummy.cost = dummy.cost * dummy.quantity;

            DOUBLE.Add(dummy);

            MessageBox.Show(Double_quantity_box.Text + " " + Double_name_box.Text + " " + "Added");

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Single_rent_button_Click(object sender, EventArgs e)
        {
            Single dummy = new Single();
            dummy.name = Single_Name_box.Text;
            dummy.quantity = Convert.ToInt32(single_quantity_box.Text);
                dummy.cost += 1000;
            dummy.gaming_setup = Convert.ToInt32(Gaming_box.Text);
                dummy.cost += dummy.gaming_setup * 1000;

                dummy.cost  = dummy.quantity * dummy.cost;
            SINGLE.Add(dummy);
            MessageBox.Show(single_quantity_box.Text + " " + Single_Name_box.Text + " Added");
        }

        private void available_show_button_Click(object sender, EventArgs e)
        {
            if(room_type_box.Text == "Single")
            {
                int cnt = 0;
                for(int i = 0; i < SINGLE.Count; i++)
                {
                    if(SINGLE[i].name == Room_name_box.Text)
                    {
                        cnt += SINGLE[i].quantity;
                    }
                }
                cnt = 10 - cnt;
                if(cnt < 0)
                {
                    Availability_box.Text = "Not enough room left";
                }
                else
                {
                    Availability_box.Text = Convert.ToString(cnt);
                }
            }
            else
            {
                int cnt = 0;
                for (int i = 0; i < DOUBLE.Count; i++)
                {
                    if (DOUBLE[i].name == Room_name_box.Text)
                    {
                        cnt += DOUBLE[i].quantity;
                    }
                }
                cnt = 10 - cnt;
                if (cnt < 0)
                {
                    Availability_box.Text = "Not enough room left";
                }
                else
                {
                    Availability_box.Text = Convert.ToString(cnt);
                }
            }
        }

        private void Air_condition_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_cost_button_Click(object sender, EventArgs e)
        {
            string check = cost_name_box.Text;
            string room = Cost_room_name_box.Text;
            if (check == "Single")
            {
                for(int i = 0; i < SINGLE.Count; i++)
                {
                    if(SINGLE[i].name == room)
                    {
                        cost_box.Text = "$" + Convert.ToString(SINGLE[i].cost);
                        break;
                    }
                }
            }
            else
            {
                for(int i = 0;i < DOUBLE.Count; i++)
                {
                    cost_box.Text = "$" + Convert.ToString(DOUBLE[i].cost);
                    break;
                }
            }
        }
    }
}
