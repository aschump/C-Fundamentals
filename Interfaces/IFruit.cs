using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //this is our content
    //anything that implements IFruit must do all of its methods and have all of its properties etc.
    public interface IFruit
    {
        string Name { get; }
        bool IsPeeled { get; set; }
        string Peel();
    }
}
