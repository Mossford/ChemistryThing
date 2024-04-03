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
            new("Hydrogen", "H", 1, false, 0),

            new("Lithium", "Li", -1, true, 1),
            new("Beryllium", "Be", -2, true, 2),
            new("Boron", "B", -3, false, 3),
            new("Carbon", "C", -4, false, 4),
            new("Nitrogen", "N", -3, false, 5),
            new("Oxygen", "O", -2, false, 6),
            new("Flourine", "F", -1, false, 7),

            new("Sodium", "Na", -1, true, 8),
            new("Magnesium", "Mg", -2, true, 9),
            new("Aluminum", "Al", -3, true, 10),
            new("Silicon", "Si", -4, false, 11),
            new("Phosphorus", "P", -3, false, 12),
            new("Sulfur", "S", -2, false, 13),
            new("Chlorine", "Cl", -1, false, 14),

            new("Potassium", "K", -1, true, 15),
            new("Calcium", "Ca", -2, true, 16),
            new("Scandium", "Sc", -3, true, 17),
            new("Titanium", "Ti", -4, true, 18),
            new("Vanadium", "V", -3, true, 19),
            new("Chromium", "Cr", -2, true, 20),
            new("Maganese", "Mn", -2, true, 21),
            //iron will just be 3
            new("Iron", "Fe", -3, true, 22),
            new("Cobalt", "Co", -3, true, 23),
            new("Nickel", "Ni", -2, true, 24),
            //copper will just be 2
            new("Copper", "Cu", -2, true, 25),
            new("Zinc", "Zn", -2, true, 26),
            new("Gallium", "Ga", -3, true, 27),
            new("Germanium", "Ge", -4, true, 28),
            new("Arsenic", "As", -3, false, 29),
            new("Selenium", "Se", -2, false, 30),
            new("Bromine", "Br", -1, false, 31),

            //just going to have silver, iodine, tin from this row
            new("Silver", "Ag", -1, true, 32),
            new("Tin", "Sn", -4, true, 33),
            new("Iodine", "I", -1, false, 34),

            // just going to have gold from this row
            //gold will just be 3
            new("Gold", "Au", -3, true, 35),

            //polyatomic ions
            new("Acetate", "C₂H₂O₂", -1, false, true, 36),
            new("Clhorate", "ClO₃", -1, false, true, 37),
            new("Iodate", "IO₃", -1, false, true, 38),
            new("Bromate", "BrO₃", -1, false, true, 39),
            new("Cynanide", "CN", -1, false, true, 40),
            new("Hydroxide", "OH", -1, false, true, 41),
            new("Nitrate", "NO₃", -1, false, true, 42),
            new("Permanganate", "MnO₄", -1, false, true, 43),
            new("Thiocyanate", "SCN", -1, false, true, 44),
            new("Carbonate", "CO₃", -2, false, true, 45),
            new("Chromate", "CrO₄", -2, false, true, 46),
            new("Dichromate", "Cr₂O₇", -2, false, true, 47),
            new("Peroxide", "O₂", -2, false, true, 48),
            new("Silicate", "SiO₃", -2, false, true, 49),
            new("Sulfate", "SO₄", -2, false, true, 50),
            new("Thiosulfate", "S₂O₃", -2, false, true, 51),
            new("Posphate", "PO₄", -3, false, true, 52),
            //acts like a metal
            new("Ammonium", "NH₄", 1, true, true, 53)
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

            "Iodide",

            "",
            "",

            //polyatomic ions
            "Acetate", 
            "Clhorate",
            "Iodate",
            "Bromate", 
            "Cynanide",
            "Hydroxide",
            "Nitrate", 
            "Permanganate",
            "Thiocyanate",
            "Carbonate",
            "Chromate",
            "Dichromate",
            "Peroxide",
            "Silicate",
            "Sulfate", 
            "Thiosulfate",
            "Posphate",
            "",
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
        };

        public static char[] vowels =
        {
            'a',
            'e',
            'i',
            'o',
            'u'
        };
    }

    public class Element
    {
        public string name { get; set; }
        public string symbol { get; set; }
        public int charge { get; set; }
        public bool isMetal { get; set; }
        public bool isPoly { get; set; }
        public int index { get; set; }

        public Element(string name, string symbol, int charge, bool isMetal, int index)
        {
            this.name = name;
            this.symbol = symbol;
            this.charge = charge;
            this.isMetal = isMetal;
            this.index = index;
        }
        public Element(string name, string symbol, int charge, bool isMetal, bool isPoly, int index)
        {
            this.name = name;
            this.symbol = symbol;
            this.charge = charge;
            this.isMetal = isMetal;
            this.isPoly = isPoly;
            this.index = index;
        }
    }

    public class IonicMolucule
    {
        public string name { get; set; }
        public string chemicalForm { get; set; }
        public Element a { get; set; }
        public Element b { get; set; }


        public IonicMolucule(string name, string chemicalForm, Element a, Element b)
        {
            this.name = name;
            this.chemicalForm = chemicalForm;
            this.a = a;
            this.b = b;
        }

        public IonicMolucule()
        {
            
        }

        public override string ToString()
        {
            return name + " " + chemicalForm;
        }
    }

    public class MolecularMolucule
    {
        public string name { get; set; }
        public string chemicalForm { get; set; }
        public Element a { get; set; }
        public Element b { get; set; }
        public uint countA { get; set; }
        public uint countB { get; set; }

        //add on acid, oxyacid, and hydrate


        public MolecularMolucule(string name, string chemicalForm, Element a, Element b, uint countA, uint countB)
        {
            this.name = name;
            this.chemicalForm = chemicalForm;
            this.a = a;
            this.b = b;
            this.countA = countA;
            this.countB = countB;
        }

        public MolecularMolucule()
        {

        }

        public override string ToString()
        {
            return name + " " + chemicalForm;
        }
    }
}
