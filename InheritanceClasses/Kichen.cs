using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClasses
{

    // : inherits properties from House class
    public class Kichen : House
    {
        //ctor tab tab to make new constructor
        public Kichen()
        {
            SquareFeet = 500;
            Flooring = FloorType.Wood;
        }
        public int NumberOfAppliance { get; set; }
        public bool HasAnIsland { get; set; }
        public string GoodPartySpace { get; set; }
    }
}
