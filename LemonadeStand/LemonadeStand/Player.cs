using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string companyName;
        public int onHandCash;

        public Player()
        {
            
        }

        public string GetCompany()
        {
            Console.WriteLine("Give a name for your company: ");
            companyName = Console.ReadLine();            
            return companyName;
                            
                        
        }
        public int SetCashBox()
        {
            CashBox cashbox = new CashBox();
            cashbox.GetCashBox();
            return onHandCash;
        }
        public int GetCashBox(int onHandCash)
        {
            

            return onHandCash;
        }
    }
}
