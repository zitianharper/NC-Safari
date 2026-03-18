using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NC_Safari
{

    public class PantheraBigCat : Mammal
    {
        public sealed override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " roars!");
        }

        public PantheraBigCat(float weight) : base(weight)
        {
            
        }


    }
}