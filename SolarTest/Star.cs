using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarTest
{
    public class Star
    {
        private int _spectralClass;
        private int _temperature;
        public Star() { }

        public Star(double _spectralClass, double _temperature)
        {
            _spectralClass = SpectralClass;
            _temperature = Temperature;
        }

        public int SpectralClass { get => _spectralClass; set => _spectralClass = value; }
        public int Temperature { get => _temperature; set => _temperature = value; }

        public virtual void Draw()
        {
            Console.WriteLine("");
        }

        public virtual void Event()
        {
            Console.WriteLine("");
        }
        public CelestialObjects CelestialObjects
        {
            get => default;
            set
            {
            }
        }
    }
}