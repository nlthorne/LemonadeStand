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
        public decimal startMoney;

        public Player()
        {
            startMoney = 25;
        }

        public string GetCompany()
        {
            Console.WriteLine("Give me a name for your company: ");
            companyName = Console.ReadLine();            
            return companyName;            
        }
    }
}
