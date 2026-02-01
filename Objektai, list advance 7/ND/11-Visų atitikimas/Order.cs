using System;
using System.Collections.Generic;
using System.Text;

namespace Objektai__list_advance_7.ND._11_Visų_atitikimas
{
    internal class Order
    {
        public  bool IsSent { get; set; }
        public string Name { get; set; }

        public Order(string name, bool isSent) 
        {
            Name = name;
            IsSent = isSent;
        }
    }
}
