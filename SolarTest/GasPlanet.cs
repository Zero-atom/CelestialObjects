using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarTest
{
    public class GasPlanet : SolarPlanet
    {
        private double _atmosphere;

        public GasPlanet() { }

        public GasPlanet(double _atmospherey)
        {
            _atmosphere = Atmosphere;
        }

        public double Atmosphere { get => _atmosphere; set => _atmosphere = value; }

        public override void Event()
        {
            Console.WriteLine("Позднее Связывание!!!!");
            base.Event();
        }
        public override void Draw()
        {
            Console.WriteLine("Позднее Связывание!!!!");
            base.Draw();
        }
    }
}