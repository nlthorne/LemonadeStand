using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        int dayNumber = 1;
        Inventory inventory;
        Customer customer;
        LemonadeStand lemonadestand;


        public Day()
        {
            inventory = new Inventory();
            customer = new Customer();
            lemonadestand = new LemonadeStand();

        }
        public void DayTracker()
        {
            dayNumber++;
        }
        public void GetDemands()
        {

        }
        
    }
}
