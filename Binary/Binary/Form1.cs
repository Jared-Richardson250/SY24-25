using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary
{
    public partial class Form1 : Form
    {
        int Total = 0;
        int[] Bits = new int[8];

        public Form1()
        {
            InitializeComponent();
        }

        private void Calc()
        {
            Total = 0;
            if (Bits[0] != 0) Total += 1;
            if (Bits[1] != 0) Total += 2;
            if (Bits[2] != 0) Total += 4;
            if (Bits[3] != 0) Total += 8;
            if (Bits[4] != 0) Total += 16;
            if (Bits[5] != 0) Total += 32;
            if (Bits[6] != 0) Total += 64;
            if (Bits[7] != 0) Total += 128;
            label1.Text = Total.ToString();
        }

        private void Bit6_TextChanged(object sender, EventArgs e)
        {
            Total = 0;
            //Bit1
            if (Bit1.Text == "1")
            {
                Bits[0] = 1;
            }
            else
            {
                Bits[0] = 0;
            }
            //Bit2
            if (Bit2.Text == "1")
            {
                Bits[1] = 1;
            }
            else
            {
                Bits[1] = 0;
            }
            //Bit3
            if (Bit3.Text == "1")
            {
                Bits[2] = 1;
            }
            else
            {
                Bits[2] = 0;
            }
            //Bit4
            if (Bit4.Text == "1")
            {
                Bits[3] = 1;
            }
            else
            {
                Bits[3] = 0;
            }
            //Bit5
            if (Bit5.Text == "1")
            {
                Bits[4] = 1;
            }
            else
            {
                Bits[4] = 0;
            }
            //Bit6
            if (Bit6.Text == "1")
            {
                Bits[5] = 1;
            }
            else
            {
                Bits[5] = 0;
            }
            //Bit7
            if (Bit7.Text == "1")
            {
                Bits[6] = 1;
            }
            else
            {
                Bits[6] = 0;
            }
            //Bit8
            if (Bit8.Text == "1")
            {
                Bits[7] = 1;
            }
            else
            {
                Bits[7] = 0;
            }
            Calc(); //calc is short for calculator
        }
    }
}
