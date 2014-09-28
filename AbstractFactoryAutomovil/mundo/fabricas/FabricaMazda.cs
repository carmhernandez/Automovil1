using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.interfaces;
using AbstractFactoryAutomovil.mundo.clases;

namespace AbstractFactoryAutomovil.mundo.fabricas
{
    class FabricaMazda : IFabricaDePartes
    {
        public IAuto crearAuto()
        {
            return new AutoMazda();
        }

        public IMotor crearMotor()
        {
            return new MotorMazda();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaMazda();
        }
    }
}
