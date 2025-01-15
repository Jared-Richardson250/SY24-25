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

namespace Binary
{
    public partial class Form1 : Form
    {
        int Total = 0;
        int[] BitsA = new int[8];
        int[] BitsB = new int[8];
        int[] BitsC = new int[8];

        public Form1()
        {
            InitializeComponent();
        }

        private void Calc()
        {
            Total = 0;
            if (BitsA[0] != 0) Total += 1;
            if (BitsA[1] != 0) Total += 2;
            if (BitsA[2] != 0) Total += 4;
            if (BitsA[3] != 0) Total += 8;
            if (BitsA[4] != 0) Total += 16;
            if (BitsA[5] != 0) Total += 32;
            if (BitsA[6] != 0) Total += 64;
            if (BitsA[7] != 0) Total += 128;
            Row1Label.Text = Total.ToString();
        }

        private void Bit6_TextChanged(object sender, EventArgs e)
        {
            Total = 0;
            //Bit1
            if (BitA1.Text == "1")
            {
                BitsA[0] = 1;
            }
            else
            {
                BitsA[0] = 0;
            }
            //Bit2
            if (BitA2.Text == "1")
            {
                BitsA[1] = 1;
            }
            else
            {
                BitsA[1] = 0;
            }
            //Bit3
            if (BitA3.Text == "1")
            {
                BitsA[2] = 1;
            }
            else
            {
                BitsA[2] = 0;
            }
            //Bit4
            if (BitA4.Text == "1")
            {
                BitsA[3] = 1;
            }
            else
            {
                BitsA[3] = 0;
            }
            //Bit5
            if (BitA5.Text == "1")
            {
                BitsA[4] = 1;
            }
            else
            {
                BitsA[4] = 0;
            }
            //Bit6
            if (BitA6.Text == "1")
            {
                BitsA[5] = 1;
            }
            else
            {
                BitsA[5] = 0;
            }
            //Bit7
            if (BitA7.Text == "1")
            {
                BitsA[6] = 1;
            }
            else
            {
                BitsA[6] = 0;
            }
            //Bit8
            if (BitA8.Text == "1")
            {
                BitsA[7] = 1;
            }
            else
            {
                BitsA[7] = 0;
            }
            Calc(); //calc is short for calculator
        }

        private void Bit6_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BitsA.Length; i++)
            {
                BitsA[i] = 0;
            }
            update();
        }

        private void update()
        {
            BitB1.Text = (BitsA[0] == 1 ? "1" : "0");
            BitB2.Text = (BitsA[1] == 1 ? "1" : "0");
            BitB3.Text = (BitsA[2] == 1 ? "1" : "0");
            BitB4.Text = (BitsA[3] == 1 ? "1" : "0");
            BitB5.Text = (BitsA[4] == 1 ? "1" : "0");
            BitB6.Text = (BitsA[5] == 1 ? "1" : "0");
            BitB7.Text = (BitsA[6] == 1 ? "1" : "0");
            BitB8.Text = (BitsA[7] == 1 ? "1" : "0");
            BitB1.Text = (BitsA[0] == 1 ? "1" : "0");
            BitB1.Text = (BitsA)
        }
    }
}
