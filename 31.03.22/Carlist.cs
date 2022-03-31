using System;
using System.Collections.Generic;
using System.Text;

namespace _31._03._22
{
    internal class Carlist
    {
        public Car[] CarArr;
        public Carlist()
        {
            CarArr = new Car[0];
        }
        public Car[] AddCar(Car model)
        {
            Array.Resize(ref CarArr, CarArr.Length + 1);
            CarArr[CarArr.Length - 1] = model;
            return CarArr;
        }
    }
}
