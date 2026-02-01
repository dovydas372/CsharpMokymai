using System;
using System.Collections.Generic;
using System.Text;

namespace PaveldejimasND._2
{
    internal class Air: Transport
    {

        public double MaxAltitudeM { get; set; }
        public int EnginesCount { get; set; }

        public Air(double maxAltitudeM, int enginesCount, string name, int rangeKm, int maxSpeedKmH, int acceleration)
        : base(name, rangeKm, maxSpeedKmH, acceleration)
        {
            MaxAltitudeM = maxAltitudeM;
            EnginesCount = enginesCount;
        }

    }
}
