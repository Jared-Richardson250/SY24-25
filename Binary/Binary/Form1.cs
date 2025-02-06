using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace NewYears
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// ///////////////////////////////////////////////////ALL TEXT BOXES/BITS///////////////////////////////////////////////////
        int[] total = new int[8];

        private void Bit1_TextChanged(object sender, EventArgs e)
        {
            if (Bit1.Text.Equals("1"))

            {
                total[0] += 1;
            }
        }
        private void Bit2_TextChanged(object sender, EventArgs e)
        {
            if (Bit2.Text.Equals("1"))

            {
                total[0] += 2;
            }
        }
        private void Bit3_TextChanged(object sender, EventArgs e)
        {
            if (Bit3.Text.Equals("1"))

            {
                total[0] += 4;
            }
        }
        private void Bit4_TextChanged(object sender, EventArgs e)
        {
            if (Bit4.Text.Equals("1"))

            {
                total[0] += 8;
            }
        }
        private void Bit5_TextChanged(object sender, EventArgs e)
        {
            if (Bit5.Text.Equals("1"))

            {
                total[0] += 16;
            }
        }
        private void Bit6_TextChanged(object sender, EventArgs e)
        {
            if (Bit6.Text.Equals("1"))

            {
                total[0] += 32;
            }
        }
        private void Bit7_TextChanged(object sender, EventArgs e)
        {
            if (Bit7.Text.Equals("1"))

            {
                total[0] += 64;
            }
        }
        private void Bit8_TextChanged(object sender, EventArgs e)
        {
            if (Bit8.Text.Equals("1"))

            {
                total[0] += 144;
            }
        }
        private void Bit9_TextChanged(object sender, EventArgs e)
        {
            if (Bit9.Text.Equals("1"))

            {
                total[1] += 1;
            }
        }
        private void Bit10_TextChanged(object sender, EventArgs e)
        {
            if (Bit10.Text.Equals("1"))

            {
                total[1] += 2;
            }
        }
        private void Bit11_TextChanged(object sender, EventArgs e)
        {
            if (Bit11.Text.Equals("1"))

            {
                total[1] += 4;
            }
        }
        private void Bit12_TextChanged(object sender, EventArgs e)
        {
            if (Bit12.Text.Equals("1"))

            {
                total[1] += 8;
            }
        }
        private void Bit13_TextChanged(object sender, EventArgs e)
        {
            if (Bit13.Text.Equals("1"))

            {
                total[1] += 16;
            }
        }
        private void Bit14_TextChanged(object sender, EventArgs e)
        {
            if (Bit14.Text.Equals("1"))

            {
                total[1] += 32;
            }
        }
        private void Bit15_TextChanged(object sender, EventArgs e)
        {
            if (Bit15.Text.Equals("1"))

            {
                total[1] += 64;
            }
        }
        private void Bit16_TextChanged(object sender, EventArgs e)
        {
            if (Bit16.Text.Equals("1"))

            {
                total[1] += 144;
            }
        }
        private void Bit17_TextChanged(object sender, EventArgs e)
        {
            if (Bit17.Text.Equals("1"))

            {
                total[2] += 1;
            }
        }
        private void Bit18_TextChanged(object sender, EventArgs e)
        {
            if (Bit18.Text.Equals("1"))

            {
                total[2] += 2;
            }
        }
        private void Bit19_TextChanged(object sender, EventArgs e)
        {
            if (Bit19.Text.Equals("1"))

            {
                total[2] += 4;
            }
        }
        private void Bit20_TextChanged(object sender, EventArgs e)
        {
            if (Bit20.Text.Equals("1"))

            {
                total[2] += 8;
            }

        }
        private void Bit21_TextChanged(object sender, EventArgs e)
        {
            if (Bit21.Text.Equals("1"))

            {
                total[2] += 16;
            }

        }
        private void Bit22_TextChanged(object sender, EventArgs e)
        {
            if (Bit22.Text.Equals("1"))

            {
                total[2] += 32;
            }
        }
        private void Bit23_TextChanged(object sender, EventArgs e)
        {
            if (Bit23.Text.Equals("1"))

            {
                total[2] += 64;
            }

        }
        private void Bit24_TextChanged(object sender, EventArgs e)
        {
            if (Bit24.Text.Equals("1"))

            {
                total[2] += 144;
            }

        }
        /// ///////////////////////////////////////////////////CONVIG BTN/RESET BTN///////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            //Line
            Line1.Text = "0";


            //Bits
            Bit1.Text = "0";
            Bit2.Text = "0";
            Bit3.Text = "0";
            Bit4.Text = "0";
            Bit5.Text = "0";
            Bit6.Text = "0";
            Bit7.Text = "0";
            Bit8.Text = "0";


            //Int
            total[0] = 0;



        }
        private void ResetBtn2_Click(object sender, EventArgs e)
        {
            //Line
            Line2.Text = "0";

            //Bits
            Bit9.Text = "0";
            Bit10.Text = "0";
            Bit11.Text = "0";
            Bit12.Text = "0";
            Bit13.Text = "0";
            Bit14.Text = "0";
            Bit15.Text = "0";
            Bit16.Text = "0";

            //Int
            total[1] = 0;
        }
        private void ResetBtn3_Click(object sender, EventArgs e)
        {
            //Line
            Line3.Text = "0";

            //Bits
            Bit17.Text = "0";
            Bit18.Text = "0";
            Bit19.Text = "0";
            Bit20.Text = "0";
            Bit21.Text = "0";
            Bit22.Text = "0";
            Bit23.Text = "0";
            Bit24.Text = "0";

            //Int
            total[2] = 0;
        }
        /// ///////////////////////////////////////////////////Changes The Lable And Shows Num///////////////////////////////////////////////////
        private void ConfigBTN_Click(object sender, EventArgs e)
        {
            Line1.Text = total[0].ToString();
            Line2.Text = total[1].ToString();
            Line3.Text = total[2].ToString();
        }
        /// ///////////////////////////////////////////////////This Makes It To Click And Chnage///////////////////////////////////////////////////
        private void Bit24_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
            {
                ((TextBox)sender).Text = "1";
            }
            
        }




    }
}