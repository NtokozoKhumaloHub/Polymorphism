using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class AUDI : Car
    {
        public string Model { get; set; }
        public AUDI(string Model,int Hp, string color) : base(Hp, color)
        {
            this.Model = Model;
            this.Hp = Hp;
            this.color = color;
            this.Brand = "AUDI";

        }

    }
}
