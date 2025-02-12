using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        CoinSlot cs = new CoinSlot();
        Products Prods = new Products();
        public Form1()
        {
            InitializeComponent();
        }

        private void QuarterButton_Click(object sender, EventArgs e)
        {
            Prods.cs.insert("Quarter");
            BalanceLabel.Text = cs.Total().ToString("C2");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Prods.cs.insert("Dollar");
            BalanceLabel.Text = cs.Total().ToString("C2");
        }

        private void DimeButton_Click(object sender, EventArgs e)
        {
            Prods.cs.insert("Dime");
            BalanceLabel.Text = cs.Total().ToString("C2");
        }

        private void NickelButton_Click(object sender, EventArgs e)
        {
            Prods.cs.insert("Nickel");
            BalanceLabel.Text = cs.Total().ToString("C2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Prods.Add("Nacho Cheese Doritos, 2");
            Prods.Add("Cool Ranch Doritos, 10");
            Prods.Add("Chex Mix, 10");
            Prods.Add("Chocolate M&Ms, 10");
            Prods.Add("Nut M&Ms, 10");
            Prods.Add("Cheetos, 10");
            Prods.Add("Limon Cheetos, 10");
            Prods.Add("Snickers, 10");
            Prods.Add("Three Muskateers, 10");
            Prods.Add("Twix, 10");
            Prods.Add("Takis, 10");
            Prods.Add("Dinamita Doritos, 10");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prods.Buy(Nacho Cheese Doritos, 2);
        }
    }
}
