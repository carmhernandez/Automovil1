using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.interfaces;
using AbstractFactoryAutomovil.mundo.clases;

namespace AbstractFactoryAutomovil.mundo.fabricas
{
    class FabricaRenault : IFabricaDePartes
    {
        public IAuto crearAuto()
        {
            return new AutoRenault();
        }

        public IMotor crearMotor()
        {
            return new MotorRenault();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaRenault();
        }
    }
}
