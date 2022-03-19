using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int x = 0, y = 0;
        public bool WinState()
        {
            // Horizontal State
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text))
                return true;
            else if ((B4.Text == B5.Text) && (B5.Text == B6.Text))
                return true;
            else if ((B7.Text == B8.Text) && (B8.Text ==B9.Text))
                return true;

            // Vertical State
            else if ((B1.Text ==B4.Text) && (B4.Text == B7.Text))
                return true;
            else if ((B2.Text == B5.Text) && (B5.Text == B8.Text))
                return true;
            else if ((B3.Text == B6.Text) && (B6.Text == B9.Text))
                return true;
           
            // Diagonal State
            else if ((B1.Text == B5.Text) && (B5.Text == B9.Text))
                return true;
            else if ((B3.Text == B5.Text) && (B5.Text == B7.Text))
                return true;

            else  return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (x <= y )
            {
                B2.Text = "X";
                x++;
            }
            else
            {
                B2.Text = "O";
                y++;
            }
            if(WinState())
            {
                if(x>y)
                {
                    MessageBox.Show("Player 1 Wins");
                }
                else
                {
                    MessageBox.Show("Player 2 Wins");
                }
            }
            result.Text = Convert.ToString(x) + "\t" + Convert.ToString(y);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (x == y)
            {
                B3.Text = "X";
                x++;
            }
            else
            {
                B3.Text = "O";
                y++;
            }
            result.Text = Convert.ToString(x) + "\t" + Convert.ToString(y);
            if (WinState())
            {
                if (x > y)
                {
                    MessageBox.Show("Player 1 Wins");
                }
                else
                {
                    MessageBox.Show("Player 2 Wins");
                }
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (x == y)
            {
                B4.Text = "X";
                x++;
            }
            else
            {
                B4.Text = "O";
                y++;
            }
            result.Text = Convert.ToString(x) + "\t" + Convert.ToString(y);
            if (WinState())
            {
                if (x > y)
                {
                    MessageBox.Show("Player 1 Wins");
                }
                else
                {
                    MessageBox.Show("Player 2 Wins");
                }
            }
        }
        private void B5_Click(object sender, EventArgs e)
        {
            if (x == y)
            {
                B5.Text = "X";
                x++;
            }
            else
            {
                B5.Text = "O";
                y++;
            }
            result.Text = Convert.ToString(x) + "\t" + Convert.ToString(y);
            if (WinState())
            {
                if (x > y)
                {
                    MessageBox.Show("Player 1 Wins");
                }
                else
                {
                    MessageBox.Show("Player 2 Wins");
                }

            }
        }
        private void B6_Click(object sender, EventArgs e)
        {
            if (x == y)
            {
                B6.Text = "X";
                x++;
            }
            else
            {
                B6.Text = "O";
                y++;
            }
            result.Text = Convert.ToString(x) + "\t" + Convert.ToString(y);
            if (WinState())
            {
                if (x > y)
                {
                    MessageBox.Show("Player 1 Wins");
                }
                else
                {
                    MessageBox.Show("Player 2 Wins");
                }
            }
        }
        private void B7_Click(object sender, EventArgs e)
        {
            if (x <= y)
            {
                B7.Text = "X";
                x++;
            }
            else
            {
                B7.Text = "O";
                y++;
            }
            result.Text = Convert.ToString(x) + "\t" + Convert.ToString(y);
            if (WinState())
            {
                if (x > y)
                {
                    MessageBox.Show("Player 1 Wins");
                }
                else
                {
                    MessageBox.Show("Player 2 Wins");
                }
            }
        }
    private void B8_Click(object sender, EventArgs e)
        {
            if (x <= y)
            {
                B8.Text = "X";
                x++;
            }
            else
            {
                B8.Text = "O";
                y++;
            }
            result.Text = Convert.ToString(x) + "\t" + Convert.ToString(y);
            if (WinState())
            {
                if (x > y)
                {
                    MessageBox.Show("Player 1 Wins");
                }
                else
                {
                    MessageBox.Show("Player 2 Wins");
                }
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (x <= y)
            {
                B9.Text = "X";
                x++;
            }
            else
            {
                B9.Text = "O";
                y++;
            }
            result.Text = Convert.ToString(x) + "\t" + Convert.ToString(y);
            if (WinState())
            {
                if (x > y)
                {
                    MessageBox.Show("Player 1 Wins");
                }
                else
                {
                    MessageBox.Show("Player 2 Wins");
                }
            }

        }

        private void B1_Click(object sender, EventArgs e)
        {
            if(x == y)
            {
                B1.Text = "X";
                x++;
            }
            else
            {
                B1.Text = "O";
                y++;
            }
            result.Text = Convert.ToString(x) + "\t" + Convert.ToString(y);
            if (WinState())
            {
                if (x > y)
                {
                    MessageBox.Show("Player 1 Wins");
                }
                else
                {
                    MessageBox.Show("Player 2 Wins");
                }
            }

        }
        
    }
}
