using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Products
    {
        public CoinSlot cs = new CoinSlot();
        Dictionary<string,int>merch=new Dictionary<string,int>();
        public void AddProduct (string Product, int count)
        {
            merch.Add(Product, count);
        }
        bool Buy(String Product, decimal Price)
        {
            return false;
        }
    }
}
