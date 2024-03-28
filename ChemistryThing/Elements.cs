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

                new("Lithium", -1, true),
                new("Beryllium", -2, true),
                new("Boron", -3, false),
                new("Carbom", -4, false),
                new("Nitrogen", -3, false),
                new("Oxygen", -2, false),
                new("Flourine", -1, false),
                
                new("Sodium", -1, true),
                new("Magnesium", -2, true),
                new("Aluminum", -3, true),
                new("Silicon", -4, false),
                new("Phosphorus", -3, false),
                new("Sulfur", -2, false),
                new("Chlorine", -1, false),

                new("Potassium", -1, true),
                new("Calcium", -2, true),
                new("Scandium", -3, true),
                new("Titanium", -4, true),
                new("Vanadium", -3, true),
                new("Chromium", -2, true),
                new("Maganese", -1, true),
                //iron will just be 3
                new("Iron", -3, true),
                new("Cobalt", -3, true),
                new("Nickel", -2, true),
                //copper will just be 2
                new("Copper", -2, true),
                new("Zinc", -2, true),
                new("Gallium", -3, true),
                new("Germanium", -4, true),
                new("Arsenic", -3, false),
                new("Selenium", -2, false),
                new("Bromine", -1, false),

                //just going to have silver, iodine, tin from this row
                new("Silver", -1, true),
                new("Tin", -4, true),
                new("Iodine", -1, false),


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
