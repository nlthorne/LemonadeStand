using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        string supplySelect;        
        int onHandLemon;
        int onHandSugar;
        int onHandIce;
        int onHandCups;


        public Store(int lemons, int sugar, int ice, int cups)
        {
            onHandLemon = lemons;
            onHandSugar = sugar;
            onHandIce = ice;
            onHandCups = cups;
        }
        public int BuyWhichItem()
        {
            Console.WriteLine("Which items do you wish to buy?/n (1)Lemons, (2)Sugar, (3)Ice, (4)Cups or (5)Return to Main Menu?");
            int supplySelect;
            supplySelect = Console.Read();            
            return supplySelect;
        }
        public void BuyInventory(int supplySelect)
        {
            switch (supplySelect)
            {
                case 1:
                    Console.WriteLine("How many lemons would like to purchase(3 lemons per pitcher)?");
                    Console.WriteLine("---Lemons costs: $0.50 per lemon---");
                    //Need to move entered value to BuyItem()                    
                    break;
                case 2:
                    Console.WriteLine("How many cups of sugar would you like to purchase(4 tbsp per pitcher/16tbsp per cup)?");
                    Console.WriteLine("---Sugar costs: $0.50 per cup---");
                    break;
                case 3:
                    Console.WriteLine("How many bags of ice would you like to buy(4 ice per pitcher/20 per bag)?");
                    Console.WriteLine("---Ice costs: $2.00 per bag---");
                    break;
                case 4:
                    Console.WriteLine("How many sleeves of cups would you like to purchase(20 cups per sleeve)?");
                    Console.WriteLine("---Cups cost: $2.00 per sleeve---");
                    break;
                case 5:
                    Console.WriteLine("Come back next time you need supplies!");
                    break;
                default:
                    Console.WriteLine("Sorry, that is not a buying option.");
                    break;
            }
        }
        public void BuyLemon()
        {
            
        }
        public void BuySugar()
        {

        }
        public void BuyIce()
        {

        }
        public void BuyCups()
        {

        }
        }

    }

}
