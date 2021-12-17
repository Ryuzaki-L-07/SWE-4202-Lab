using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management
{
    public partial class Form1 : Form
    {
        List <medicine> MEDICINE = new List <medicine> ();
        List <accessories> ACCESSORIES = new List <accessories> ();
        List <string> INFO = new List<string> ();
        int COST = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void STOCK_Click(object sender, EventArgs e)
        {
            medicine dummy = new medicine ();
            dummy.Name = Med_name_box.Text;
            dummy.Type = Med_type_box.Text;
            dummy.Company_name = Med_company_box.Text;
            dummy.Production_Date = Med_production_date_box.Text;
            dummy.Expired_Date = Med_expired_date_box.Text;
            dummy.quantity = Convert.ToInt32 (Med_quantity_box.Text);
            dummy.cost = Convert.ToInt32(Med_cost_box.Text);

            MEDICINE.Add (dummy);
            MessageBox.Show("MEDICINE ADDED");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ACC_STOCK_Click(object sender, EventArgs e)
        {
            accessories dummy = new accessories();
            dummy.Name = Acc_name_box.Text;
            dummy.Type = Acc_type_box.Text;
            dummy.quantity = Convert.ToInt32(Acc_quantity_box.Text);
            dummy.cost = Convert.ToInt32(Acc_cost_box.Text);
            dummy.Company_name = Acc_company_name_box.Text;
            dummy.warrany_date = Acc_warranty_box.Text;

            ACCESSORIES.Add (dummy);
            MessageBox.Show("Accessories Added");
        }

        private void BUY_Click(object sender, EventArgs e)
        {
            if(Buy_type_box.Text == "Medicine")
            {
                for(int i = 0; i < MEDICINE.Count; i++)
                {
                    if(MEDICINE[i].Name == Buy_name_box.Text)
                    {
                        MEDICINE[i].quantity --;
                        COST += (MEDICINE[i].cost * Convert.ToInt32(Buy_quantity_box.Text));
                        break;
                    }
                }
            }

            else
            {
                for(int i = 0; i < ACCESSORIES.Count;i++)
                {
                    if(ACCESSORIES[i].Name == Buy_name_box.Text)
                    {
                        ACCESSORIES[i].quantity--;
                        COST += (ACCESSORIES[i].cost * Convert.ToInt32(Buy_quantity_box.Text));
                        break;
                    }
                }
            }
            MessageBox.Show("BOUGHT");
        }

        private void BALANCE_Click(object sender, EventArgs e)
        {
            Cost_List.Items.Clear();
            Cost_List.Items.Add(COST);
        }
    }
}
