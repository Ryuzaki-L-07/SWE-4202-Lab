using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Rental;

namespace CAR_RENTAL_SERVICE
{
    public partial class Form1 : Form
    {
        List<Car> CAR = new List<Car>();
        List<User> USER = new List<User>();
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User dum = new User();
            dum.ID = user_id_box.Text;
            dum.Name = user_name_box.Text;
            dum.Destination = user_destination_box.Text;
            dum.Adress = user_adress_box.Text;

            USER.Add(dum);
            MessageBox.Show("USER ADDED");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car dum = new Car();
            dum.Name=car_name_box.Text;
            dum.Model = car_model_box.Text;
            dum.Num_of_cars += Convert.ToInt32(car_number_box.Text);

            CAR.Add(dum);
            MessageBox.Show("CAR SAVED");
        }

        private void history_car_name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < USER.Count; i++)
            {
                if(USER[i].ID == rent_user_id.Text)
                {
                    USER[i].rented_car = rent_car_name.Text;
                }
            }

            for(int i = 0; i < CAR.Count; i++)
            {
                if(CAR[i].Name == rent_car_name.Text)
                {
                    CAR[i].Num_of_cars--;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dum = history_user_id.Text;
            for(int i = 0; i < USER.Count; i++)
            {
                if(USER[i].ID == dum)
                {
                    history_user_name_box.Text = USER[i].Name;
                    history_user_rentcar_box.Text = USER[i].rented_car;
                    history_user_adress_box.Text = USER[i].Adress;
                    history_user_destination_box.Text = USER[i].Destination;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string car_name = history_car_name_box.Text;

            MessageBox.Show(car_name);
            for(int i = 0; i < CAR.Count; i++)
            {
                if(CAR[i].Name == history_car_name_box.Text)
                {
                    history_car_model_box.Text = CAR[i].Model;
                    history_car_availability_box.Text = Convert.ToString(CAR[i].Num_of_cars);
                    break;
                }
            }
            /*for(int i = 0; i < CAR.Count; i++)
            {
                if(CAR[i].Name == car_name)
                {
                    history_car_model_box.Text = CAR[i].Model;
                    history_car_availability_box.Text = Convert.ToString(CAR[i].Num_of_cars);
                }
            }*/
        }
    }
}
