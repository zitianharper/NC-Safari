using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public class Bat : Mammal, IHunt, IFly
    {
        public void Hunt()
        { 
            Console.WriteLine("Bat is hunting in the air!");
         }

        public void Fly()
        {
            Console.WriteLine("Bat is Flying!");
        }
        public Bat(float weight) : base(weight)
        {

        }

        public void MakeSound() 
        {
            Console.WriteLine("Bat Sqeek");
        }
    }
}
