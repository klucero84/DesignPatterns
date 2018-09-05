using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // This factory uses the EnemyShipFactory interface
    // to create very specific UFO Enemy Ship

    // This is where we define all of the parts the ship
    // will use by defining the methods implemented
    // being ESWeapon and ESEngine

    // The returned object specifies a specific weapon & engine

    public class UFOBossEnemyShipFactory : IEnemyShipFactory{

	    // Defines the weapon object to associate with the ship
	
	    public IWeapon AddGun() {
		    return new UFOBossGun(); // Specific to Boss UFO
	    }

	    // Defines the engine object to associate with the ship
	
	    public IEngine AddEngine() {
		    return new UFOBossEngine(); // Specific to Boss UFO
	    }

    }
}
