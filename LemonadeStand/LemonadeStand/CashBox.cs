using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class CashBox
    {
        public int onHandCash;

        public CashBox(int startCash=25)
        {
            
        }
        public void GetCashBox()
        {
            onHandCash = 25;
            onHandCash = Console.Read();
        }
    }
}