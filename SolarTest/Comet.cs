using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarTest
{
    public class Comet : SmallBodies
    {
        private double _composition;

        public Comet() { }

        public Comet(double _composition)
        {
            _composition = Composition;
        }

        public double Composition { get => _composition; set => _composition = value; }


     
    }
}