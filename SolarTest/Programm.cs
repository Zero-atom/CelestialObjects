using System;

namespace SolarTest
{
    class Programm 
    {
        delegate void mValueTuple(); // тип делегата
        static void Main(string[] args)
            {
                mValueTuple msg; // объект делегата (к 5 относиться)
                /* 4 Лабораторная */
                SolarPlanet first = new TerrastrialPlanets();
                SolarPlanet second = new GasPlanet();

                first.Draw(); // вызов раннего связывания
                Console.WriteLine("\n");
                second.Draw(); // вызво позднего связывания

                first.Event(); // вызов раннего связывания
                Console.WriteLine("\n");
                second.Event(); // вызво позднего связывания

                /* 5 Лабораторная */
                IDetect msgfirst = new SolarPlanet();
                IDetect1 msgsecond = new SolarPlanet();

                msg = msgfirst.Detect;
                Console.WriteLine("\n");
                msg += msgsecond.Detect;

                msg();
                Console.ReadKey();
            }
    }
}