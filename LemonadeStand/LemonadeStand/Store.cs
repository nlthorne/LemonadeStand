﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        int onHandLemon;
        int onHandSugar;
        int onHandIce;
        int onHandCups;
        int onHandCash;
        

        public Store()
        {         

        }

       

        public void BuyWhichItem()
        {
            Console.WriteLine("Which items do you wish to buy?/n (1)Lemons, (2)Sugar, (3)Ice, (4)Cups or (5)Return to Main Menu?");
            int supplySelect;
            supplySelect = Console.Read();            
            BuyInventory(supplySelect);
        }
        public void BuyInventory(int supplySelect)
        {
            switch (supplySelect)
            {
                case 1:
                    Console.WriteLine("How many lemons would like to purchase(3 lemons per pitcher)?");
                    Console.WriteLine("---Lemons costs: $1.00 per lemon---");
                    BuyLemon();
                    
                                      
                    break;
                case 2:
                    Console.WriteLine("How many cups of sugar would you like to purchase(1 cup of sugar per pitcher)?");
                    Console.WriteLine("---Sugar costs: $1.00 per cup---");
                    BuySugar();
                    break;
                case 3:
                    Console.WriteLine("How many bags of ice would you like to buy(4 ice per pitcher/20 per bag)?");
                    Console.WriteLine("---Ice costs: $2.00 per bag---");
                    BuyIce();
                    break;
                case 4:
                    Console.WriteLine("How many sleeves of cups would you like to purchase(20 cups per sleeve)?");
                    Console.WriteLine("---Cups cost: $2.00 per sleeve---");
                    BuyCups();
                    break;
                case 5:
                    Console.WriteLine("Come back next time you need supplies!");
                    break;
                default:
                    Console.WriteLine("Sorry, that is not a buying option.");
                    BuyWhichItem();
                    break;
            }
        }
        public int BuyLemon()
        {
            int buyLemons;
            buyLemons = Console.Read();
            onHandLemon += buyLemons;            
            return onHandLemon;
            
        }
        public int BuySugar()
        {
            int buySugar;
            buySugar = Console.Read();
            onHandSugar += buySugar;
            return onHandSugar;
        }
        public int BuyIce()
        {
            int buyIce;
            buyIce = Console.Read();
            onHandIce += buyIce;
            return onHandIce;
        }
        public int BuyCups()
        {
            int buyCups;
            buyCups = Console.Read();
            onHandCups += buyCups;
            return onHandCups;
        }
        public int ReduceCash(int onHandCash)
        {


            
            return onHandCash;
        }
    }

}


