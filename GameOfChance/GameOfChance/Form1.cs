using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfChance
{
    public partial class Form1 : Form
    {
                int payout = 0;
                int answer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private TextBox GetTextBox2()
        {
            return NumberTB;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            NumberTB.Enabled = true;
            BetTB.Enabled = true;
            button1.Enabled = false;
            textBox1.Text = "";
            NumberTB.Text = "";
            BetTB.Text = "";
            PayoutTB.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberTB.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BetTB.Enabled = false;
                if (NumberTB.Enabled == false && BetTB.Enabled == false)
                {
                    button1.Enabled = true;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Random random = new Random();
                int num = random.Next(1, 2);
                textBox1.Text = num.ToString();
                button1.Enabled = false;
                PayoutTB.Text = payout.ToString();
                NumberTB.Text = answer.ToString();
                if (textBox1.Text == answer.ToString())
                {
                    payout *= payout * 2;
                }
            }
        }
    }
}