using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarTest
{
    public class Planet
    {
        private int _distanceFromSun;
        private int _numberOf;
        private int _temperature;

        public Planet()
        {
        }
        public Planet(int _distanceFromSun, int _numberOf, int _temperature)
        {
            _distanceFromSun = DistanceFromSun;

        }

        public int DistanceFromSun
            {
            get => _distanceFromSun;
            private set => _distanceFromSun = value;
            }
        public CelestialObjects CelestialObjects
        {
            get => default;
            set
            {
            }
        }
        public virtual Draw()
        {
            Console.WriteLine("{0} , {1} , {2}", _distanceFromSun, )
        }
    }
}