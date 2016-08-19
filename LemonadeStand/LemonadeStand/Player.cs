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
        CashBox cashbox;
        LemonadeStand lemonadestand;

        public Player()
        {
            cashbox = new CashBox();
            lemonadestand = new LemonadeStand();
        }

        public void SetCompany()
        {
            Console.WriteLine("Give a name for your company: ");
            companyName = Console.ReadLine();  
                      
        }
        public string GetCompany()
        {
            return companyName;
        }
        

        
    }
}
