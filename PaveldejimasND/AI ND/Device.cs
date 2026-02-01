using System;
using System.Collections.Generic;
using System.Text;

namespace PaveldejimasND.AI_ND
{
    internal class Device
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Device(string brand, string model)
        {


            Brand = brand; Model = model;
        }

        public virtual string Info()
        {
            return $"Device: {Brand} {Model}";
        }

    }
}
