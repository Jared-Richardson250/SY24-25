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
        public Form1()
        {
            InitializeComponent();
        }

        private void QuarterButton_Click(object sender, EventArgs e)
        {
            cs.insert("Quarter");
            BalanceLabel.Text = cs.Total().ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cs.insert("Dollar");
            BalanceLabel.Text = cs.Total().ToString();
        }

        private void DimeButton_Click(object sender, EventArgs e)
        {
            cs.insert("Dime");
            BalanceLabel.Text = cs.Total().ToString();
        }

        private void NickelButton_Click(object sender, EventArgs e)
        {
            cs.insert("Nickel");
            BalanceLabel.Text = cs.Total().ToString();
        }
    }
}
