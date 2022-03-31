using System;

namespace _31._03._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zəhmət olmasa Maşın  sayını  qeyd edin : ");
            int Carsize = Convert.ToInt32(Console.ReadLine());

            //Car[] cars = new Car[Carsize];
            Carlist carlist = new Carlist();

            for (int i = 0; i < Carsize; i++)
            {



                Console.WriteLine("Car modeli teyin edin:");
                string Brand = Console.ReadLine();
                Console.WriteLine("Car Rengini teyin edin:");
                string Color = Console.ReadLine();
                Console.WriteLine("Car yuruyusunu teyin edin:");
                int Millage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Benzin bakinin umumi hecmi:");
                int FuelCapastiy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bakda olan benzinin hecmi:");
                double CurrentFuel = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("1Km - e yandirdigi benzinin hecmi:");
                double FuelFor1km = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("\n----\n");


                Console.WriteLine("\t~~~New Car~~~");

                Car car = new Car(FuelCapastiy, CurrentFuel, FuelFor1km, Brand, Color, Millage);




                carlist.AddCar(car);
            }
            Console.WriteLine("\nTek deyerlere gore Menu:");
          
            byte Enter = 0;

        }

    }
}