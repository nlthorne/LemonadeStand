using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    
    class LemonadeStand
    {
        bool soldCup;
        Customer customer;
        Player player;
        Weather weather;

        public LemonadeStand()
        {
            customer = new Customer();
            player = new Player();
            weather = new Weather();

        }
        //public void CupSold()
        //{
        //    if (soldCup == true)
        //    {
        //        onHandCup - 1;
        //    }
         
        //}
    }
}
