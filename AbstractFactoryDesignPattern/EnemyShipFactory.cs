using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public interface IEnemyShipFactory
    {
        IWeapon AddGun();
        IEngine AddEngine();

    }
}
