using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        Button[] btnGrid = new Button[100];
        public Form1()
        {
            InitializeComponent();
            /* btnGrid[0] = button1;
            btnGrid[2] = button2;
            btnGrid[3] = button3;
            btnGrid[4] = button4;
            btnGrid[5] = button5;
            btnGrid[6] = button6;
            btnGrid[7] = button7;
            btnGrid[8] = button8;
            btnGrid[9] = button9;
            btnGrid[10] = button10; */
            for (int i = 0; i < 100; i++)
            {
                btnGrid[i] = (Button)Controls["button" + (i + 1)];
            }
            for (int i = 0; i < 100; i++)
            {
                btnGrid[i].BackColor = Color.Green;
            }
            for (int i = 0;i < 100; i++)
            {
                
            }
            int Time = 0;
            timer1 = new Timer();
            timer1.Tick = Time++;
            label4.Text = Time.ToString();
        }
    }
}
