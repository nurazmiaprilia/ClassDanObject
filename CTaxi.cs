using System;

namespace ClassDanObject
{
    public class CTaxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
            if(OnDuty==true)
            {
                Console.WriteLine("On Duty: Yes");
            } else {
                Console.WriteLine("On Duty: No");
            }
            Console.WriteLine("Number of Passenger: {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", DriverName);
        }

        public void DropOffPasengger()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang", DriverName);
        }
    }
}
