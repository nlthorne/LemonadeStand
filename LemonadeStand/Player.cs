using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string playerName;
        public int iceToBuy;
        public int cupsToBuy;
        Cashbox cashbox;
        LemonadeStand lemonadestand;
        Inventory inventory;

        public Player()
        {
            cashbox = new Cashbox();
            lemonadestand = new LemonadeStand();
            inventory = new Inventory();
        }

        public void SetCompany()
        {
            Console.WriteLine("Please enter your name: ");
            playerName = Console.ReadLine();

        }
        public string GetCompany()
        {
            return playerName;
        }

        public List<Lemon> BuyLemons()
        {
            Console.WriteLine("How many lemons do you want to buy?");
            int lemonsDesired = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < lemonsDesired; i++)
            {
                Lemon lemon = new Lemon();
                inventory.lemons.Add(lemon);
            }
            return inventory.lemons;
        }
        public void BuyCups()
        {
            Console.WriteLine("How many sleeves of cups do you want to buy?");
            int cupsToBuy = Convert.ToInt32(Console.ReadLine());
            AddCups(cupsToBuy);
        }
        public List<Cup> AddCups(int cupsToBuy)
        {
            int numberOfCupsPerSleeve = 20;
            for (int i = 0; i < cupsToBuy * numberOfCupsPerSleeve; i++)
            {
                inventory.cups.Add(new Cup());
            }
            return inventory.cups;
        }
        public List<Sugar> BuySugar()
        {
            Console.WriteLine("How many cups of sugar would you like to buy?");
            int sugarDesired = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sugarDesired; i++)
            {
                Sugar sugar = new Sugar();
                inventory.sugar.Add(sugar);
            }
            return inventory.sugar;
        }
        public void BuyIce()
        {
            Console.WriteLine("How many bags of ice do you want to buy?");
            int iceToBuy = Convert.ToInt32(Console.ReadLine());   
            AddIce(iceToBuy);
        }
        public List<Ice> AddIce(int iceToBuy)
        {
            int numberOfCubesPerBag = 20;
            for (int i = 0; i < iceToBuy * numberOfCubesPerBag; i++)
            {
                inventory.ice.Add(new Ice());
            }
            return inventory.ice;
        }
        
        

    }
}
