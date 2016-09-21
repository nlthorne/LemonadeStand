
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LemonadeStand
{
    public class Customer
    {
        public List<Customer> customers;
        public int thirst;
        public int mood;
        public int numberOfCustomer;
        public string name = "Customer";
        Weather weather;
        Price price;
        Demand demand;
        

        public Customer(string name)
        {
            weather = new Weather();
            price = new Price();
            demand = new Demand();
            customers = new List<Customer>();
            GetMood();
            GetThirst();
            demand.GetPriceOpinion();
            weather.GetCustomerWeather();// fix this logic and how to pull in the randomWeather result for customer reaction
            
        }

        public List<Customer> GetCustomers(int numberofCustomers)
        {
            Random random = new Random();
            for (int i = 0; i < numberofCustomers; i++)
            {
                Customer customer = new Customer(name +i);
                customers.Add(customer);
                Thread.Sleep(5);
            }

            //add weather, price, random mood, random thirst to each specific customer
            return customers;
        }
        public int GetThirst()
        {
            Random random = new Random();
            thirst = random.Next(0, 4);
            return thirst;
        }
        public int GetMood()
        {
            Random random = new Random();
            mood = random.Next(0, 4);
            return mood;
        }
    }
}
