using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class CoinSlot
    {
        private double m_money;
        public void insert(string Coin)
        {
            if (Coin == "Dollar") m_money += 1;
            if (Coin == "Quarter") m_money += .25;
            if (Coin == "Dime") m_money += .1;
            if (Coin == "Nickel") m_money += .05;
        }

        public void CoinReturn()
        {
            m_money = 0;
        }
        public double Total()
        {
            return m_money;
        }
    }
}
