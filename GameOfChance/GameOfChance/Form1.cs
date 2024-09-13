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
        public Form1()
        {
            InitializeComponent();
        }

        private TextBox GetTextBox2()
        {
            return textBox2;
        }

        private void button1_Click(object sender, EventArgs e, TextBox textBox2, int Payout, string answer)
        {
            int Answer;
            Random random = new Random();
            int num = random.Next(1, 35);
            textBox1.Text = num.ToString();
            button1.Enabled = false;
            if (textBox1.Text = answer)
            {
                Payout *= 2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }
    }
}