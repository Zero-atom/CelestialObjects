using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarTest
{
    public class TerrastrialPlanets : SolarPlanet
    {
        private double _atmosphere;

        public TerrastrialPlanets() { }

        public TerrastrialPlanets(double _atmospherey)
        {
            _atmosphere = Atmosphere;
        }

        public double Atmosphere { get => _atmosphere; set => _atmosphere = value; }

        public new void Draw()
        {
            Console.WriteLine("Ранее Связывание!!!!");
            base.Draw();
        }
        public  new void Event()
        {
            Console.WriteLine("Ранее Связывание!!!!");
            base.Event();
        }
    }
}