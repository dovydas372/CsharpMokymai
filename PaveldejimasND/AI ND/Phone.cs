using System;
using System.Collections.Generic;
using System.Text;

namespace PaveldejimasND.AI_ND
{
    internal class Phone:Device
    {
        public bool HasSim { get; set; }
    
    
        public Phone(bool hasSim, string brand, string model) : base(brand, model)
        {
            HasSim = hasSim;

        }

        public override string Info()
        {
            string simText = HasSim ? "Yes" : "No";
            return base.Info() + $"| HasSim: {simText}";
        }
    }
}
