using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public abstract class EnemyShip
    {
	
        public string Name { get; set; }
        // Newly defined objects that represent weapon & engine
        // These can be changed easily by assigning new parts 
        // in UFOEnemyShipFactory or UFOBossEnemyShipFactory
        public IWeapon Weapon { get; set; }
	    public IEngine Engine { get; set; }
	
	    public abstract void MakeShip();
	
	    // Because I defined the toString method in engine
	    // when it is printed the String defined in toString goes
	    // on the screen
	
	    public void FollowHeroShip(){
		
		    Console.WriteLine(Name + " is following the hero at " + Engine );
		
	    }
	
	    public void DisplayEnemyShip(){
		
		    Console.WriteLine(Name + " is on the screen");
		
	    }
	
	    public void EnemyShipShoots(){
		
		    Console.WriteLine(Name + " attacks and does " + Weapon);
		
	    }
	
	    // If any EnemyShip object is printed to screen this shows up
	
	    public String ToString(){
		
		    String infoOnShip = "The " + Name + " has a top speed of " + Engine + 
				    " and an attack power of " + Weapon;
		
		    return infoOnShip;
		
	    }
	
    }
}
