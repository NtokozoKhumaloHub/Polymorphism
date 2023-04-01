using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW BMW = new BMW("M3", 450, "Blue Crison");
            BMW.ShowDetails();
            BMW.RepairCar();

            AUDI AUDI = new AUDI("S3", 550, "Blue Sky");
            AUDI.ShowDetails();
            AUDI.RepairCar();


            Console.ReadLine();
        }
    }
}
