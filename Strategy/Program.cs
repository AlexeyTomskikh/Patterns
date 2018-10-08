using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            cat.PerformRun();

            Console.ReadKey();
        }
    }
}
