using System;
using System.Collections.Generic;
using System.Text;

namespace PaveldejimasND._2
{
    internal class Boat:Water
    {
        public Boat(double lengthM, double draftM, string name, int rangeKm, int maxSpeedKmH, int acceleration)
            : base(lengthM, draftM, name, rangeKm, maxSpeedKmH, acceleration)
        {



        }

        public override double MaxSpeedinfo()
        {
            double maxSpeedToKnots = Math.Round(base.MaxSpeedinfo() / 1.852,2);
            return maxSpeedToKnots;
        }
    }
}
