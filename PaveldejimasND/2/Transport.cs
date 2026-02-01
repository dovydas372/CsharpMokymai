using System;
using System.Collections.Generic;
using System.Text;

namespace PaveldejimasND._2
{
    internal class Transport
    {
        public string Name { get; set; }
        public int RangeKm { get; set; }
        public int MaxSpeed { get; set; }
        public int Acceleration { get; set; }

        public Transport (string name, int rangeKm, int maxSpeed, int acceleration)
        {
            Name = name;
            RangeKm = rangeKm;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
        }

        public virtual double MaxSpeedinfo()
        {
            return MaxSpeed;
        }

        public double TimeTo100()
        {
            double timeTo100 = 100 / Acceleration;
            return timeTo100;
        }


    }
}
