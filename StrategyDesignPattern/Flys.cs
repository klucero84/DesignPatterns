using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    interface IFlys
    {
        string Fly();
    }

    class ItFlys : IFlys
    {
        public string Fly()
        {
            return "Flying High";
        }
    }

    class CantFly : IFlys
    {
        public string Fly()
        {
            return "I can't fly";
        }
    }
}
