using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarTest
{
    public class CelestialObjects
    {
        private int _numberOfObjects;
        private int _mass;
        private int _size;
        private int _name;
        private int _density;
        private int _diametr;

        public CelestialObjects() { }

        public CelestialObjects(int _mass, int _density, int _numberOfObjects, int _size, int _name, int _diametr)
        {
            _mass = Mass;
            _density = Density;
            _numberOfObjects = NumberOfObjects;
            _size = Size;
            _name = Name;
            _diametr = Diametr;
        }

        public int Mass { get => _mass; set => _mass = value; }
        public int Density { get => _density; set => _density = value; }
        public int NumberOfObjects { get => _numberOfObjects; set => _numberOfObjects = value; }
        public int Size { get => _size; set => _size = value; }
        public int Name { get => _name; set => _name = value; }
        public int Diametr { get => _diametr; set => _diametr = value; }
    }
}