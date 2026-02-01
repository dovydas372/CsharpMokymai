using System;
using System.Collections.Generic;
using System.Text;

namespace PaveldejimasND._2
{
    internal class Plane : Air
    {
        public Plane(double maxAltitudeM, int enginesCount, string name, int rangeKm, int maxSpeedKmH, int acceleration)
        : base(maxAltitudeM, enginesCount, name, rangeKm, maxSpeedKmH, acceleration)
        {
           
        }

        public override double MaxSpeedinfo()
        {
            
            double maxSpeedMahs = Math.Round(base.MaxSpeedinfo() / 1225,2);
            return maxSpeedMahs;
        }
    }
}
