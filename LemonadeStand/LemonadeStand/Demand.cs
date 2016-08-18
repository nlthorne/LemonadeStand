using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Demand
    {
        public int thirstType;
        public int moodType;
        public int priceOpinion;
        public int pricePerCup;

        public Demand()
        {
            
        }
        public int GetThirstType()
        {
            Random random = new Random();
            thirstType = random.Next(0, 4);
            return thirstType;
        }
        public int GetMood()
        {
            Random random = new Random();
            moodType = random.Next(0, 4);
            return moodType;
        }
        public int GetPriceOpinion(int pricePerCup)
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
            else if (pricePerCup == 1.00)
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
