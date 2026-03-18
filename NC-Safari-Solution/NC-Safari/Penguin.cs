using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    internal class Penguin : Bird, ISwim, IHunt
    {
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming in the water!");
        }

        public void Hunt()
        {
            Console.WriteLine("Penguin is hunting in the water");
        }

        public Penguin(float weight) : base(weight)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Penguin sqarrrrrrrk");
        }

    }
}
