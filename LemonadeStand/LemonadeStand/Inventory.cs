using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public int onHandLemon;
        public int onHandSugar;
        public int onHandIce;
        public int onHandCups;

        public Inventory(int lemons, int sugar, int ice, int cups)
        {
            lemons = onHandLemon;
            sugar = onHandSugar;
            ice = onHandIce;
            cups = onHandCups;
        }
        public void CheckInventory()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Current Inventory:/n Lemons: {0}/n Sugar: {1}/n Ice: {2}/n Cups: {3}", onHandLemon, onHandSugar, onHandIce, onHandCups );
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Do you wish to purchase supplies? yes/no?");
            string buy = Console.ReadLine();
            if (buy == "yes")
            {
                //Go to Class Store, BuyWhichItem method
                Store store = new Store();
                store.BuyWhichItem();
            }
            else
            {
                Console.WriteLine("See you next time.");
                //Return user to main interface.
            }


        }

    }
}
