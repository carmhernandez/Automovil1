using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryAutomovil.mundo.interfaces
{
    interface IFabricaDePartes
    {
        IAuto crearAuto();
        IMotor crearMotor();
        ICarroceria crearCarroceria();
    }
}
