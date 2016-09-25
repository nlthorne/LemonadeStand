using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    
    public class UserInput
    {
        private int inventoryOptionMin;
        private int inventoryOptionMax;
        private int recipeIngredientQuantityMin;
        private int recipeIngredientQuantityMax;
        private int numOfDaysMin;
        private int numOfDaysMax;
        
        public UserInput()
        {
            inventoryOptionMin = 1;
            inventoryOptionMax = 4;
            recipeIngredientQuantityMin = 1;
            recipeIngredientQuantityMax = 10;
            numOfDaysMin = 7;
            numOfDaysMax = 21;
        }

        public void IntroduceGame()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("Create your own recipe and sell as much lemonade as you can.");
            Console.WriteLine("Your sales will take into account the weather and the price you set.");
            Console.WriteLine("You have $20 to get started, good luck.");
        }

        public string SetPlayerName()
        {
            Console.WriteLine("Please enter your name?");
            return Console.ReadLine();
        }

        public int SetInventory(string ingredient)
        {
            int option;

            switch (ingredient)
            {
                case "lemon":
                    Console.WriteLine("\nHow many lemons would you like to buy(Spoil = 7 days)?");
                    Console.WriteLine("1: 5 for $0.60");
                    Console.WriteLine("2: 20 for $2.00");
                    Console.WriteLine("3: 50 for $4.00");
                    Console.WriteLine("4: No Purchase. ");
                    Console.WriteLine("Please enter (1-4) to select:");
                    break;

                case "sugar":
                    Console.WriteLine("\nHow many cups of sugar would you like to buy(Spoil = 3 days)?");
                    Console.WriteLine("1: 5 for $0.60");
                    Console.WriteLine("2: 20 for $2.00");
                    Console.WriteLine("3: 100 for $9.00");
                    Console.WriteLine("4: No Purchase. ");
                    Console.WriteLine("Please enter (1-4) to select:");
                    break;

                case "ice":
                    Console.WriteLine("\nHow many ice cubes would you like to buy(Spoil = daily)?");
                    Console.WriteLine("1: 100 for $0.80");
                    Console.WriteLine("2: 250 for $1.80");
                    Console.WriteLine("3: 500 for $2.50");
                    Console.WriteLine("4: No Purchase. ");
                    Console.WriteLine("Please enter (1-4) to select:");
                    break;

                case "cup":
                    Console.WriteLine("\nHow many cups would you like to buy?");
                    Console.WriteLine("1: 50 for $3.00");
                    Console.WriteLine("2: 100 for $5.00");
                    Console.WriteLine("3: 200 for $8.00");
                    Console.WriteLine("4: No Purchase. ");
                    Console.WriteLine("Please enter (1-4) to select:");
                    break;
            }

	        while ((!int.TryParse(Console.ReadLine(), out option)) || ((option < inventoryOptionMin) || (option > inventoryOptionMax)))
	        {
                     Console.WriteLine("Please enter one of the four options!");             
	        }
            return option;

        }

        public double SetPrice()
        {
            double price;
            Console.WriteLine("How much do you want to charge per cup today?");
            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Invalid price, please enter a valid price.");
            }
            return price;
        }

        public int SetRecipe(string ingredient)
        {
            int quantity;
            switch (ingredient)
            {
                case "ice":
                    Console.WriteLine("How many ice cubes per cup?");
                    break;
                case "sugar":
                    Console.WriteLine("How many cups of sugar per pitcher");
                    break;
                default:
                    Console.WriteLine("How many {0} per pitcher?", ingredient);
                    break;

            }

            while ((!int.TryParse(Console.ReadLine(), out quantity)) || ((quantity < recipeIngredientQuantityMin) || (quantity > recipeIngredientQuantityMax)))
            {
                Console.WriteLine("Please enter a quantity between 1-10.");

            }
            return quantity;

        }

        public int SetDaysofOperation()
        {
            int quantity;
            Console.WriteLine("How many days would you like to play(7 day minimum, 21 day maximum)?");
            while ((!int.TryParse(Console.ReadLine(), out quantity)) || ((quantity < numOfDaysMin) || (quantity > numOfDaysMax)))
            {
                {
                    Console.WriteLine("Please enter number of days.");

                }
            }
            return quantity;
        }

        public void DisplayWeatherForecast(Weather weather, int dayNumber)
        {
            Console.WriteLine("\nForecast for Day {0} is {1} degrees and {2} ", dayNumber, weather.GetWeatherTemperature(), weather.GetWeatherConditions().ToLower());
        }

        public void DisplayActualWeather(Weather weather, int dayNumber)
        {
            Console.WriteLine("\nThe actual weather for Day {0} was {1} degrees and {2}", dayNumber, weather.GetWeatherTemperature(), weather.GetWeatherConditions().ToLower());
        }

        public void DisplayCash(Store store)
        {
            Console.WriteLine("\nYou have {0:$0.00} to purchase supplies.", store.GetCashOnHand());
        }

        public void DisplayDailyResults(Day day, int dayNumber)
        {
            Console.WriteLine("\n {0} potential customers and sold {1} cups of lemonade for {2:$0.00} in sales on Day {3}.", day.GetNumOfCustomers(), 
                day.GetNumOfBuyingCustomers(), day.GetDailyRevenue(), dayNumber);
            Console.WriteLine("Your expenses on Day {0} were {1:$0.00}.", dayNumber, day.GetDailyExpenses());
            Console.WriteLine("Your net income for Day {0} was {1:$0.00}", dayNumber, (day.GetDailyRevenue() - day.GetDailyExpenses()));

        }

        public void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine("Current Inventory: {0} lemons, {1} cups of sugar, {2} ice cubes and {3} cups.", inventory.GetLemonInventoryCount(), inventory.GetSugarInventoryCount(), inventory.GetIceInventoryCount(), inventory.GetCupInventoryCount());
        }

        public void DisplaySpoilage(Inventory inventory)
        {
            Console.WriteLine("{0} lemons, {1} sugars and {2} ice cubes spoiled.", +
            inventory.GetLemonsExpiredCount(),
            inventory.GetSugarExpiredCount(),
            inventory.GetIceExpiredCount());
        }

        public void DisplayFinalResults(Store store)
        {
            Console.WriteLine("End of game. You made {0:$0.00} and spent {1:$0.00} on supplies for a net income of {2:$0.00}",
                store.GetTotalRevenue(), store.GetTotalExpenses(), store.GetTotalRevenue() - store.GetTotalExpenses()); 
                
            
        }
    }
}
