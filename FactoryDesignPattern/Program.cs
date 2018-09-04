using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyShip ufo;
            EnemyShipFactory factory = new EnemyShipFactory();

            Console.WriteLine("What Type of Ship? ");
            string input = Console.ReadLine();
            //this gets to stay the same if the make ship logic does change
            ufo = factory.MakeEnemyShip(input);
            DoStuff(ufo);
        }

        private static void DoStuff(EnemyShip ufo)
        {
            ufo.DisplayEnemyShip();
            ufo.FollowHeroShip();
            ufo.EnemyShipShoots();
        }
    }
}
