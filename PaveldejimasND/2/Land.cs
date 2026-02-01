using System;
using System.Collections.Generic;
using System.Text;

namespace PaveldejimasND._2
{
    internal class Land : Transport
    {

        public int Wheels { get; set; }
        public string FuelType { get; set; }
         
        public Land(int wheels, string fuelType, string name, int rangeKm, int maxSpeed, int acceleration) : base(name, rangeKm, maxSpeed, acceleration)
        {
            Wheels = wheels;
            FuelType = fuelType;
        }


    }
}
