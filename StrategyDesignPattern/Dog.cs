using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    class Dog : Animal
    {
        public Dog()
        {
            Sound = "Bark";
            FlyingType = new CantFly();
        }

        public void DigHole()
        {
            Console.WriteLine("Dug a hole");
        }
    }
}
