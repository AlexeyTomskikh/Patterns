﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class FlyFast : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Летаю медленно!");
        }
    }
}
