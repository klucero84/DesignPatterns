using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // This is the only class that needs to change, if you
// want to determine which enemy ships you want to
// provide as an option to build

    public class UFOEnemyShipBuilding : EnemyShipBuilding
    {
	    protected override EnemyShip MakeEnemyShip(string typeOfShip)
        {
		    EnemyShip theEnemyShip = null;
		
		    // If UFO was sent grab use the factory that knows
		    // what types of weapons and engines a regular UFO
		    // needs. The EnemyShip object is returned & given a name
		    IEnemyShipFactory shipPartsFactory = new UFOEnemyShipFactory();
		    if(typeOfShip == "UFO")
            {
			    
			    theEnemyShip = new UFOEnemyShip(shipPartsFactory);
			    theEnemyShip.Name = "UFO Grunt Ship";
			
		    }
            // If UFO BOSS was sent grab use the factory that knows
		    // what types of weapons and engines a Boss UFO
		    // needs. The EnemyShip object is returned & given a name
            else if(typeOfShip =="UFO BOSS")
            {
			    theEnemyShip = new UFOBossEnemyShip(shipPartsFactory);
			    theEnemyShip.Name = "UFO Boss Ship";
			
		    } 
		
		    return theEnemyShip;
	    }
    }
}
