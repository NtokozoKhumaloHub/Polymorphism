using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car
    {
        public int Hp { get; set; }
        public string color { get; set; }

        public string Brand { get; set; }

        public Car() { }

        public Car(int hp, string color)
        {
            this.Hp = hp;
            this.color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"This is a {color} {Brand} and it has {Hp} HorsePower.");
        }

        public void RepairCar()
        {
            Console.WriteLine("The Car has been repaired.");
        }
    }
}
