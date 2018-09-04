using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    class Animal
    {
        private int _weight;

        public string Name { get; set; }

        public double Heignt { get; set; }

        public int Weight {
            get => _weight;
            set =>  _weight =  value > 0 ? value : 0; }

        public string FavoriteFood { get; set; }

        public double Speed { get; set; }

        public string Sound { get; set; }

        public IFlys FlyingType { get; set; }

        public string TryToFly()
        {
            return FlyingType.Fly();
        }
    }
}
