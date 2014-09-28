using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.interfaces;
using AbstractFactoryAutomovil.mundo.clases;

namespace AbstractFactoryAutomovil.mundo.fabricas
{
    class FabricaChevrolet : IFabricaDePartes
    {
        
        public IAuto crearAuto()
        {
            return new AutoChevrolet();
        }

        public IMotor crearMotor()
        {
            return new MotorChevrolet();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaChevrolet();
        }
    }
    }
