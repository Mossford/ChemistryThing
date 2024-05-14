using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChemistryThing
{

    public interface IElement
    {
        public abstract string getName();
        public abstract float getMass();
        public abstract int getCharge();
    }

    public static class Elements
    {

        //array for the data
        public static Element[] data =
        {
            new("Hydrogen", "H", 1, false, 0, 1.01f),

            new("Lithium", "Li", 1, true, 1, 6.94f),
            new("Beryllium", "Be", 2, true, 2, 9.01f),
            new("Boron", "B", -3, false, 3, 10.81f),
            new("Carbon", "C", -4, false, 4, 12.01f),
            new("Nitrogen", "N", -3, false, 5, 14.01f),
            new("Oxygen", "O", -2, false, 6, 16.00f),
            new("Flourine", "F", -1, false, 7, 19.00f),

            new("Sodium", "Na", 1, true, 8, 22.99f),
            new("Magnesium", "Mg", 2, true, 9, 24.31f),
            new("Aluminum", "Al", 3, true, 10, 26.98f),
            new("Silicon", "Si", -4, false, 11, 28.10f),
            new("Phosphorus", "P", -3, false, 12, 31.00f),
            new("Sulfur", "S", -2, false, 13, 32.10f),
            new("Chlorine", "Cl", -1, false, 14, 35.45f),

            new("Potassium", "K", 1, true, 15, 39.10f),
            new("Calcium", "Ca", 2, true, 16, 40.10f),
            new("Scandium", "Sc", 3, true, 17, 45.00f),
            new("Titanium", "Ti", 4, true, 18, 47.87f),
            new("Vanadium", "V", 3, true, 19, 50.94f),
            new("Chromium", "Cr", 2, true, 20, 52.00f),
            new("Maganese", "Mn", 2, true, 21, 54.94f),
            //iron will just be 3
            new("Iron", "Fe", 3, true, 22, 55.85f),
            new("Cobalt", "Co", 3, true, 23, 58.93f),
            new("Nickel", "Ni", 2, true, 24, 58.70f),
            //copper will just be 2
            new("Copper", "Cu", 2, true, 25, 63.55f),
            new("Zinc", "Zn", 2, true, 26, 65.41f),
            new("Gallium", "Ga", 3, true, 27, 69.72f),
            new("Germanium", "Ge", 4, true, 28, 72.64f),
            new("Arsenic", "As", -3, false, 29, 74.92f),
            new("Selenium", "Se", -2, false, 30, 78.96f),
            new("Bromine", "Br", -1, false, 31, 79.90f),

            //just going to have silver, iodine, tin from this row
            new("Silver", "Ag", 1, true, 32, 107.87f),
            new("Tin", "Sn", 4, true, 33, 118.71f),
            new("Iodine", "I", -1, false, 34, 126.90f),

            // just going to have gold from this row
            //gold will just be 3
            new("Gold", "Au", 3, true, 35, 196.97f),

            //polyatomic ions
            new("Acetate", "C₂H₂O₂", -1, false, true, 36, 58.04f),
            new("Clhorate", "ClO₃", -1, false, true, 37, 84.45f),
            new("Iodate", "IO₃", -1, false, true, 38, 174.90f),
            new("Bromate", "BrO₃", -1, false, true, 39, 127.90f),
            new("Cynanide", "CN", -1, false, true, 40, 26.01f),
            new("Hydroxide", "OH", -1, false, true, 41, 17.01f),
            new("Nitrate", "NO₃", -1, false, true, 42, 62.00f),
            new("Permanganate", "MnO₄", -1, false, true, 43, 118.94f),
            new("Thiocyanate", "SCN", -1, false, true, 44, 58.11f),
            new("Carbonate", "CO₃", -2, false, true, 45, 60.01f),
            new("Chromate", "CrO₄", -2, false, true, 46, 116.00f),
            new("Dichromate", "Cr₂O₇", -2, false, true, 47, 216.00f),
            new("Peroxide", "O₂", -2, false, true, 48, 32.00f),
            new("Silicate", "SiO₃", -2, false, true, 49, 76.10f),
            new("Sulfate", "SO₄", -2, false, true, 50, 87.10f),
            new("Thiosulfate", "S₂O₃", -2, false, true, 51, 94.2f),
            new("Posphate", "PO₄", -3, false, true, 52, 95.00f),
            //acts like a metal
            new("Ammonium", "NH₄", 1, true, true, 53, 18.04f)
        };


        public static string[] nonMetalNamings =
        {
            "Hydride",

            "",
            "",
            "",
            "Carbde",
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

            "",
            "",
            "Iodide",

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

        public static string[] metalActivity =
        {
            "Lithium",
            "Potassium",
            "Barium",
            "Calcium",
            "Sodium",
            "Magnesium",
            "Aluminum",
            "Zinc",
            "Chromium",
            "Iron",
            "Cadmium",
            "Cobalt",
            "Nickel",
            "Tin",
            "Lead",
            "Hydrogen",
            "Copper",
            "Mercury",
            "Silver",
            "Platinum",
            "Gold"
        };

        public static string[] nonMetalAcitivty =
        {
            "Flourine",
            "Chlorine",
            "Bromine",
            "Iodine"
        };



    }

    public class Element : IElement
    {
        public string name { get; set; }
        public string symbol { get; set; }
        public int charge { get; set; }
        public bool isMetal { get; set; }
        public bool isPoly { get; set; }
        public int index { get; set; }
        public float mass { get; set; }

        public Element(string name, string symbol, int charge, bool isMetal, int index, float mass)
        {
            this.name = name;
            this.symbol = symbol;
            this.charge = charge;
            this.isMetal = isMetal;
            this.index = index;
            this.mass = mass;
        }
        public Element(string name, string symbol, int charge, bool isMetal, bool isPoly, int index, float mass)
        {
            this.name = name;
            this.symbol = symbol;
            this.charge = charge;
            this.isMetal = isMetal;
            this.isPoly = isPoly;
            this.index = index;
            this.mass = mass;
        }

        public string getName()
        {
            return name;
        }

        public float getMass()
        {
            return mass;
        }

        public int getCharge()
        {
            return charge;
        }
    }

    public class IonicMolucule : IElement
    {
        public string name { get; set; }
        public string chemicalForm { get; set; }
        public Element a { get; set; }
        public Element b { get; set; }

        public uint amountA;
        public uint amountB;


        public IonicMolucule(string name, string chemicalForm, Element a, Element b, uint amountA, uint amountB)
        {
            this.name = name;
            this.chemicalForm = chemicalForm;
            this.a = a;
            this.b = b;
            this.amountA = amountA;
            this.amountB = amountB;
        }

        public IonicMolucule()
        {
            
        }

        public override string ToString()
        {
            return name + " " + chemicalForm;
        }

        public string getName()
        {
            return name;
        }

        public float getMass()
        {
            return a.mass * amountA + b.mass * amountB;
        }

        public int getCharge()
        {
            //this should be neutral
            return 0;
        }
    }

    public class MolecularMolucule : IElement
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

        public string getName()
        {
            return name;
        }

        public float getMass()
        {
            return a.mass * countA + b.mass * countB;
        }

        public int getCharge()
        {
            //Should be neutral
            return 0;
        }
    }
}
