using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{

    [Obsolete("Use IFly, ISwim, IHunt", true)]
    public interface IMove
    {
       public void Move();
       
    }
}
