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
        public override void info()
        {
            Console.WriteLine($"Bycle brand: {Brand}, Bycle color: {Color}");
        }
        public void Drive()
        {
            Console.WriteLine("Qəth ediləcək KM-i qeyd edin");
            double PassMill = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Qəth edilən KM:{PassMill}");
        }

    }
}
