using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        decimal pricePerCup;
        int dayNumber = 1;
        Inventory inventory;
        Customer customer;
        LemonadeStand lemonadestand;
        Weather weather;


        public Day()
        {
            inventory = new Inventory();
            customer = new Customer();
            lemonadestand = new LemonadeStand();
            weather = new Weather();

        }
        public void DayTracker()
        {
            dayNumber++;
        }
        public decimal GetSellPrice()
        {
            Console.WriteLine("What price do you want to sell at today?");
            pricePerCup = Convert.ToDecimal(Console.ReadLine());
            return pricePerCup;
        }
        //public void GetDemands()
        //{

        //}
    }
}
