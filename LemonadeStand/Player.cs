﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string name;
        public Store store;

        public Player(string name)
        {
            this.name = name;
            this.store = new Store();
        }


    }
}
