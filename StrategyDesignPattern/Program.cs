using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal woofy = new Dog();
            Animal chirpy = new Bird();

            Console.WriteLine("dog:" + woofy.TryToFly());

            Console.WriteLine("bird:" + chirpy.TryToFly());

            woofy.FlyingType = new ItFlys();

            Console.WriteLine("dog:" + woofy.TryToFly());
        }
    }
}
