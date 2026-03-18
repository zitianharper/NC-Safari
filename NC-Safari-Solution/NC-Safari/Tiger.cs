using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public class Tiger : PantheraBigCat, IHunt
    {
        public void Hunt()
        { 
            Console.WriteLine("Tiger is hunting on land!");
         }

        public Tiger(float weight) : base(weight)
        {

        }

        public void MakeSound() 
        {
            Console.WriteLine("Tiger Roaaaaar");
        }
    }
}
