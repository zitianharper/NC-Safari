using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public class Goose : Bird, ISwim, IFly
    {
        public void Swim()
        { 
            Console.WriteLine("Goose is swimming!");
         }

        public void Fly()
        {
            Console.WriteLine("Goose is Flying!");
        }
        public Goose(float weight) : base(weight)
        {

        }

        public void MakeSound() 
        {
            Console.WriteLine("Goose Honk");
        }
    }
}
