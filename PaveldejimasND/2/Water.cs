using System;
using System.Collections.Generic;
using System.Text;

namespace PaveldejimasND._2
{
    internal class Water : Transport
    {

        public double LengthM { get; set; }
        public double DraftM { get; set; }

        public Water(double lengthM, double draftM, string name, int rangeKm, int maxSpeedKmH, int acceleration)
            : base(name, rangeKm, maxSpeedKmH, acceleration)
        {
            LengthM = lengthM;
            DraftM = draftM;
        }
    }
}
