using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarTest
{
    public class SmallBodies
    {
        private int _form;
        private int _tajectoryOfMovement;


        public SmallBodies() { }

        public SmallBodies(int _form, int _tajectoryOfMovement)
        {
            _form = Form;
            _tajectoryOfMovement = TajectoryOfMovement;
        }
        public int Form { get => _form; set => _form = value; }
        public int TajectoryOfMovement { get => _tajectoryOfMovement; set => _tajectoryOfMovement = value; }
        public CelestialObjects CelestialObjects
        {
            get => default;
            set
            {
            }
        }
    }
}