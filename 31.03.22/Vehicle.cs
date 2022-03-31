using System;
using System.Collections.Generic;
using System.Text;

namespace _31._03._22
{
    internal class Vehicle
    {

        public string Brand;
        public string Color;
        public int Millage;
        public Vehicle(string brand, string color, int mill)
        {
            Brand = brand;
            Color = color;
            Millage = mill;
        }
        public Vehicle(string brand, string color)
        {
            Brand = brand;
            Color = color;

        }
        public virtual void Info()
        {

        }

    }
    
}
