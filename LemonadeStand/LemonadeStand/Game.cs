using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Day day;
        Store store;
        Player player;
        Weather weather;
        Customer customer;



        public Game()
        {
            day = new Day();
            store = new Store();
            player = new Player();
            weather = new Weather();
            customer = new Customer();


        }
        internal void GetCompany()
        {
            throw new NotImplementedException();
        }
        internal void GetCashBox()
        {
            throw new NotImplementedException();
        }
    }
}
