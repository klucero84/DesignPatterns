﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // EnemyShipBuilding handles orders for new EnemyShips
		    // You send it a code using the orderTheShip method &
		    // it sends the order to the right factory for creation
	
		    EnemyShipBuilding MakeUFOs = new UFOEnemyShipBuilding();
 
		    EnemyShip theGrunt = MakeUFOs.OrderTheShip("UFO");
		    Console.WriteLine(theGrunt + "\n");
		
		    EnemyShip theBoss = MakeUFOs.OrderTheShip("UFO BOSS");
		    Console.WriteLine(theBoss + "\n");
        }
    }
}
