using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class UFOBossEnemyShip : EnemyShip
    {
	
	    // We define the type of ship we want to create
	    // by stating we want to use the factory that 
	    // makes enemy ships
	
	    private IEnemyShipFactory _shipFactory;
	
	    // The enemy ship required parts list is sent to 
	    // this method. They state that the enemy ship
	    // must have a weapon and engine assigned. That 
	    // object also states the specific parts needed
	    // to make a Boss UFO versus a Regular UFO
	
	    public UFOBossEnemyShip(IEnemyShipFactory shipFactory){
		
		    _shipFactory = shipFactory;
		
	    }
	
	    // EnemyShipBuilding calls this method to build a 
	    // specific UFOBossEnemyShip

	    public override void MakeShip() {
		
		    // TODO Auto-generated method stub
		
		    Console.WriteLine("Making enemy ship " + Name);
		
		    // The specific weapon & engine needed were passed in
		    // shipFactory. We are assigning those specific part
		    // objects to the UFOBossEnemyShip here
		
		    Weapon = _shipFactory.AddGun();
		    Engine = _shipFactory.AddEngine();
		
	    }
	
    }
}
