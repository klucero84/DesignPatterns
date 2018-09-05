using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Here we define a basic component of a space ship
    // Any part that implements the interface ESWeapon
    // can replace that part in any ship

    public class UFOGun : IWeapon{
	
	    // EnemyShip contains a reference to the object
	    // ESWeapon. It is stored in the field weapon
	
	    // The Strategy design pattern is being used here
	
	    // When the field that is of type ESUFOGun is printed 
	    // the following shows on the screen
	
	    public string ToString(){
		    return "20 damage";
	    }
	
    }
}
