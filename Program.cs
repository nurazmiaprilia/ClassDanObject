using System;

namespace ClassDanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            CTaxi taxi = new CTaxi();

            taxi.DriverName = "Nurazmi";
            taxi.OnDuty = true;
            taxi.NumPassenger = 28;

            taxi.TaxiInfo();
            Console.WriteLine();
            taxi.PickUpPassenger();
            taxi.DropOffPasengger();

            Console.ReadKey();
        }
    }
}