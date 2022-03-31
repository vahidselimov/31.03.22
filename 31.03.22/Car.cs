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
        public override void info()
        {
            Console.WriteLine($"Car brand: {Brand}, Car color: {Color}, Car total milage:{Millage}, Car fuel capacity: {FuelCapacity}.");
        }
        public void Drive()
        {
            bool search = false;
            if (FuelCapacity>=CurrentFuel)
            {
                Console.WriteLine("Qəth ediləcək KM- qeyd edin");
                double PassMill = Convert.ToDouble(Console.ReadLine());

                double KmAddLitr = PassMill * FuelFor1km;
                CurrentFuel -= KmAddLitr;
                Console.WriteLine("Movcut olan Benzinlə yol gedilə bilinəcək");
                if (CurrentFuel>=0)
                {
                    search = true;
                    Console.WriteLine(search);
                    Console.WriteLine($"\nQalan benzin: {CurrentFuel}  V ");
                    Console.WriteLine($"Gedilən yol: {Millage + PassMill} KM");
                }
                else
                {
                    Console.WriteLine(search);

                }
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz Current Fuel,Maşının benzin bakından çoxdur");
            }
        }
    }
}


