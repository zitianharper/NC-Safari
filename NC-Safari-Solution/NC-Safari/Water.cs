using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NC_Safari.Program;

namespace NC_Safari
{
    public class Water : SafariEnvironment<ISwim>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                Console.WriteLine($"{typeof(Animal).Name} is swimming!");
            }
        }
    }
}
