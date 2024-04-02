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
                new("Hydrogen", 1, false, 0),

                new("Lithium", -1, true, 1),
                new("Beryllium", -2, true, 2),
                new("Boron", -3, false, 3),
                new("Carbon", -4, false, 4),
                new("Nitrogen", -3, false, 5),
                new("Oxygen", -2, false, 6),
                new("Flourine", -1, false, 7),
                
                new("Sodium", -1, true, 8),
                new("Magnesium", -2, true, 9),
                new("Aluminum", -3, true, 10),
                new("Silicon", -4, false, 11),
                new("Phosphorus", -3, false, 12),
                new("Sulfur", -2, false, 13),
                new("Chlorine", -1, false, 14),

                new("Potassium", -1, true, 15),
                new("Calcium", -2, true, 16),
                new("Scandium", -3, true, 17),
                new("Titanium", -4, true, 18),
                new("Vanadium", -3, true, 19),
                new("Chromium", -2, true, 20),
                new("Maganese", -1, true, 21),
                //iron will just be 3
                new("Iron", -3, true, 22),
                new("Cobalt", -3, true, 23),
                new("Nickel", -2, true, 24),
                //copper will just be 2
                new("Copper", -2, true, 25),
                new("Zinc", -2, true, 26),
                new("Gallium", -3, true, 27),
                new("Germanium", -4, true, 28),
                new("Arsenic", -3, false, 29),
                new("Selenium", -2, false, 30),
                new("Bromine", -1, false, 31),

                //just going to have silver, iodine, tin from this row
                new("Silver", -1, true, 32),
                new("Tin", -4, true, 33),
                new("Iodine", -1, false, 34),


            };


        public static string[] nonMetalNamings =
        {
            "Hydride",

            "",
            "",
            "Boride",
            "Carbide",
            "Nitride",
            "Oxide",
            "Flouride",

            "",
            "",
            "",
            "Silicide",
            "Phosphide",
            "Sulfide",
            "Chloride",

            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "Bromide",

            "Iodide"
        };

        public static string[] Subscripts =
        {
            "\u2081", // 1
            "\u2082", // 2
            "\u2083", // 3
            "\u2084", // 4
            "\u2085", // 5
            "\u2086", // 6
            "\u2087", // 7
            "\u2088", // 8
            "\u2089" // 9
        };

        public static string[] AmountPrefixes =
        {
            "Mono", // 1
            "Di", // 2
            "Tri", // 3
            "Tetra", // 4
            "Penta", // 5
            "Hexa", // 6
            "Hepta", // 7
            "Octa", // 8
            "Nona", // 9
            "Deca" // 10
        }
    }

    public class Element
    {
        public string name { get; set; }
        public int charge { get; set; }
        public bool isMetal { get; set; }
        public int index { get; set; }

        public Element(string name, int charge, bool isMetal, int index)
        {
            this.name = name;
            this.charge = charge;
            this.isMetal = isMetal;
            this.index = index;
        }
    }
}
