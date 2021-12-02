using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarTest
{
    public class Comets : SmallBodies
    {
        private double _composition;

        public Comets() { }

        public Comets(double _composition)
        {
            _composition = Composition;
        }

        public double Composition { get => _composition; set => _composition = value; }

    }
}
}