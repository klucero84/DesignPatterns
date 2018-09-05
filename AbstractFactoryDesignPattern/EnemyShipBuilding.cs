using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public abstract class EnemyShipBuilding {
	
	    // This acts as an ordering mechanism for creating
	    // EnemyShips that have a weapon, engine & name
	    // & nothing else
	
	    // The specific parts used for engine & weapon depend
	    // upon the String that is passed to this method
 
	    protected abstract EnemyShip MakeEnemyShip(string typeOfShip);
 
	    // When called a new EnemyShip is made. The specific parts
	    // are based on the String entered. After the ship is made
	    // we execute multiple methods in the EnemyShip Object
	
	    public EnemyShip OrderTheShip(string typeOfShip) {
		    EnemyShip theEnemyShip = MakeEnemyShip(typeOfShip);
		
		    theEnemyShip.MakeShip();
		    theEnemyShip.DisplayEnemyShip();
		    theEnemyShip.FollowHeroShip();
		    theEnemyShip.EnemyShipShoots();
		
		    return theEnemyShip;
		
	    }
    }
}
