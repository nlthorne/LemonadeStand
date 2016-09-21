using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemon> lemons;
        public List<Cup> cups;
        public List<Ice> ice;
        public List<Sugar> sugar;
        
        public Inventory()
        {
            lemons = new List<Lemon>();
            cups = new List<Cup>();
            ice = new List<Ice>();
            sugar = new List<Sugar>();

        }


        public void CheckInventory()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Current Inventory:/n Lemons: {0}/n Sugar: {1}/n Ice: {2}/n Cups: {3}", lemons.Count, sugar.Count, ice.Count, cups.Count);
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
                
            }
            //onHandLemon = lemons.Count;  for later use: if you want to check specifically how many on hand from list
            //onHandCups = cups.Count;

        }
    }
}
