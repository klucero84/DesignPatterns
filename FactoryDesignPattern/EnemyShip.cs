using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public abstract class EnemyShip
    {
        public string Name { get; set; }
        public double Damage { get; set; }

        public void FollowHeroShip()
        {
            Console.WriteLine("Follow Hero Ship");
        }
        public void DisplayEnemyShip()
        {
            Console.WriteLine("Enemy Ship on screen");
        }
        public void EnemyShipShoots()
        {
            Console.WriteLine(Name + " attacks and does " + Damage + " damage to hero");
        }
    }
}
