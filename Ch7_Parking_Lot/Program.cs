using System;

namespace Ch7_Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot p1 = new ParkingLot(1, 2, 3);
            // 1 true & 3 false
            Console.WriteLine(p1.AddCar("Small"));
            Console.WriteLine(p1.AddCar("small"));
            Console.WriteLine(p1.AddCar("small"));
            Console.WriteLine(p1.AddCar("small"));

            // 2 true & 2 false
            Console.WriteLine(p1.AddCar("Medium"));
            Console.WriteLine(p1.AddCar("medium"));
            Console.WriteLine(p1.AddCar("medium"));
            Console.WriteLine(p1.AddCar("medium"));

            //3 true & 1 false
            Console.WriteLine(p1.AddCar("Large"));
            Console.WriteLine(p1.AddCar("large"));
            Console.WriteLine(p1.AddCar("Large"));
            Console.WriteLine(p1.AddCar("Large"));
        }
    }
}
