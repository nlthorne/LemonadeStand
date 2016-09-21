using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Cashbox
    {
        public Cashbox()
        {

        }
        public int onHandCash;

        public Cashbox(int startCash = 25)
        {
            onHandCash = startCash;
        }
        public int GetCashBox()
        {
            return onHandCash;
        }
    }
}
