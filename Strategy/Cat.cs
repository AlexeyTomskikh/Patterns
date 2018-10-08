using System;
using System.Text;

namespace Strategy
{
    public class Cat : Animal
    {
        public Cat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            runBehavior = new RunSlow();
        }

        public void MakeSound()
        {
            Console.WriteLine("Я кошка");
        }

        public void MakeAny()
        {
            Console.WriteLine("кошка переопределила виртуальный");
        }
    }
}
