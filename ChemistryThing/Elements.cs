using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemistryThing
{

    public static class Elements
    {

        //enum for the index to the data array
        enum Names
        {
            Hydrogen,
            Helium,
            
        }

        //array for the data
        public static Element[] data = 
            {
                //Hydrogen will be positive in this case
                new("Hydrogen", 1, false),
                new("Helium", 0, false),
            };
    }

    public class Element
    {
        public string name { get; set; }
        public int charge { get; set; }
        public bool isMetal { get; set; }

        public Element(string name, int charge, bool isMetal)
        {
            this.name = name;
            this.charge = charge;
            this.isMetal = isMetal;
        }
    }
}
