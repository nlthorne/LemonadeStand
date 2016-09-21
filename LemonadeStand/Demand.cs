using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Demand
    {
        Price price;
        Weather weather;
        public int priceOpinion;
        public int pricePerCup;
        
        public Demand()
        {
            price = new Price();
            weather = new Weather();
        }
        public int GetPriceOpinion()//pricePerCup should be decimal
        {
            //get the value that player sets as their daily price per cup.
            if (pricePerCup >= 2.50)
            {
                priceOpinion = 0;

            }
            else if (pricePerCup == 2.00)
            {
                priceOpinion = 1;

            }
            else if (pricePerCup == 1.50)
            {
                priceOpinion = 2;

            }
            else if (pricePerCup <= 1.00)
            {
                priceOpinion = 3;
            }
            else
            {
                Console.WriteLine("Something went wrong in the GetPriceOpinion Function");
                //error handling goes here.

            }
            return priceOpinion;
        }
    }
}
