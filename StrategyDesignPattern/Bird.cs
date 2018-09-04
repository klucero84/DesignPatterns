using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    class Bird : Animal
    {
        public Bird()
        {
            Sound = "Tweet";
            FlyingType = new ItFlys();
        }
    }
}
