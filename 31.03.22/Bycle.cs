using System;
using System.Collections.Generic;
using System.Text;

namespace _31._03._22
{
    internal class Bycle : Vehicle
    {
        public Bycle(string brand, string color) : base(brand, color)
        {

        }
        public override void Info()
        {

            Console.WriteLine($"Bycle brand: {Brand}, Bycle color: {Color}.");
        }
    }
}
