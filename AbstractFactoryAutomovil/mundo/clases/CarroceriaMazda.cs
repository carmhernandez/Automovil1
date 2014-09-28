using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.interfaces;

namespace AbstractFactoryAutomovil.mundo.clases
{
    class CarroceriaMazda : ICarroceria
    {
        public string darNombre()
        {
            return "Carroceria Mazda";
        }
    }
}
