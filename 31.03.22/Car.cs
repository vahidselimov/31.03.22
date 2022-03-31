using System;
using System.Collections.Generic;
using System.Text;

namespace _31._03._22
{
    internal class Car:Vehicle
    {
        public int FuelCapacity;
        public double CurrentFuel;
        public double FuelFor1km;
        public Car(int capacity, double currentfule, double fuelfor1km, string brand, string color, int mill) : base(brand, color, mill)
        {
            FuelCapacity = capacity;
            CurrentFuel = currentfule;
            FuelFor1km = fuelfor1km;
        }
        public override void Info()
        {
            Console.WriteLine($"Car brand: {Brand}, Car color: {Color}, Car total milage:{Millage}, Car fuel capacity: {FuelCapacity}.");
        }

    }
}


