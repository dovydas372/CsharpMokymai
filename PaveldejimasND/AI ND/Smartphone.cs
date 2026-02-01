using System;
using System.Collections.Generic;
using System.Text;

namespace PaveldejimasND.AI_ND
{
    internal class Smartphone : Phone
    {
        public int CameraMP { get; set; }

        public Smartphone(bool hasSim, string brand, string model, int cameraMP)
            : base(hasSim, brand, model)
        {
            CameraMP = cameraMP;
        }

        public override string Info()
        {


            return base.Info() + $" | Camera: {CameraMP}MP";
        }

    }

}
