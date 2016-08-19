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

        public Inventory()
        {
            
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
        //public int MakePitcher()
        //{
        //    //taking supplies from inventory, making amount of pitchers determined, and updating values of inventory
              //int pitcherMade;
              //Console.WriteLine("How many pitchers do you wish to make today?");
              //pitcherMade = Console.ReadLine();
              //


        //    //return these values to UpdateInventory()
        //}
        //public int UpdateInventory()
        //{
              //per pitcher made = onHandLemon - 2, onHandSugar - 1, onHandIce - 4,
        //}
    }
}
