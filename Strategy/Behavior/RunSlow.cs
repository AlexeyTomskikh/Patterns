using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class RunSlow : IRunBehavior
    {
        public void Run()
        {
            Console.WriteLine("Бегу медленно!");
        }
    }
}
