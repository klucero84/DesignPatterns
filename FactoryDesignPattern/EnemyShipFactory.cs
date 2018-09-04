using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    /// <summary>
    /// Factory that houses class constructor logic
    /// </summary>
    class EnemyShipFactory
    {
        /// <summary>
        /// Makes a new instance of a subclass of enemyship
        /// </summary>
        /// <param name="shipType">some input to evaluate at runtime</param>
        /// <returns>an new instance based on runtime input</returns>
        public EnemyShip MakeEnemyShip(string shipType)
        {
            EnemyShip newShip = null;

            if (shipType == "rocket")
            {
                newShip = new RocketEnemyShip();
            } else if (shipType == "big")
            {
                newShip = new BigUFOEnemyShip();
            } else
            {
                newShip = new UFOEnemyShip();
            }
            return newShip
        }
    }
}
