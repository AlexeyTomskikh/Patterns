using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Dog : Animal
    {
        public Dog(){

            runBehavior = new RunFast();
        }
        public void MakeSound()
        {
            Console.WriteLine("Я собака");
        }
    }
}
