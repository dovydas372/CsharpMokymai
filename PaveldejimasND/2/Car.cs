using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PaveldejimasND._2
{
    internal class Car : Land
    {
        public Car(string name, int rangeKm, int maxSpeed, int acceleration, int wheels, string fuelType)
            : base(wheels, fuelType, name, rangeKm, maxSpeed, acceleration)
        {

        }
        
        public override double MaxSpeedinfo()
        {
            double maxSpeedKm = base.MaxSpeedinfo();
            return maxSpeedKm / 1.6;
        }

    }
}
