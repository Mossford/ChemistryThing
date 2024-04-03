using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChemistryThing
{
    public static class NamingElements
    {
        public static IonicMolucule CreateIonic(Element a, Element b)
        {
            string name = "";
            string chemicalForm = "";

            //If with a metal
            if(a.isMetal && !b.isMetal)
            {
                name += a.name;

                name += " ";

                //add on the -ide naming
                name += Elements.nonMetalNamings[b.index];

                chemicalForm += a.symbol;
                //swap the charges
                if (MathF.Abs(b.charge) != 1)
                    chemicalForm += Elements.Subscripts[(int)MathF.Abs(b.charge) - 1];

                chemicalForm += b.symbol;
                //swap the charges
                if (MathF.Abs(a.charge) != 1)
                    chemicalForm += Elements.Subscripts[(int)MathF.Abs(a.charge) - 1];

                return new(name, chemicalForm, a, b);
            }

            throw new Exception("Elements could not form ionic molucule " + a.name + " and " + b.name);
        }

        public static string NameIonic(IonicMolucule molucule)
        {
            return molucule.name;
        }

        public static string ChemicalFormIonic(IonicMolucule molucule)
        {
            return molucule.chemicalForm;
        }


        public static IonicMolucule CreateMolecular(Element a, Element b, uint countA = 1, uint countB = 1)
        {
            string name = "";
            string chemicalForm = "";

            //check if one is a metal as we cannot form
            if (a.isMetal ||  b.isMetal)
                throw new Exception("Elements could not form molecular molucule " + a.name + " and " + b.name);

            //get the charges and start by removing from chargeA by the amount chargeB
            //add to the count of each element by 1
            //if the chargeA does not equal 0 then we still have charge left
            //start loop and add to the chargeACount by chargeA and add another A element

            uint countElementA = countA;
            uint countElementB = countB;
            uint chargeCountA = (uint)MathF.Abs(a.charge) * countA;
            uint chargeCountB = (uint)MathF.Abs(b.charge) * countB;

            chargeCountA -= (uint)MathF.Abs(b.charge);

            //if we are not neutral then start adding elements
            while (chargeCountA > 0)
            {
                //if we have charge on a that is less than chargeB then add on to a and get all the element b 
                if (chargeCountA < (uint)MathF.Abs(b.charge))
                {
                    while (chargeCountA < chargeCountB)
                    {
                        chargeCountA += (uint)MathF.Abs(a.charge);
                        countElementA++;
                    }
                }
                else
                {
                    chargeCountA -= (uint)MathF.Abs(b.charge);
                    chargeCountB += (uint)MathF.Abs(b.charge);
                    countElementB++;
                }
            }

            //add on prefix
            if (countElementA > 1 && countElementA <= 10 && !a.isPoly)
            {
                //check if vowel is the same
                for (int i = 0; i < Elements.vowels.Length; i++)
                {
                    char c = Elements.vowels[i];
                    char ending = Elements.AmountPrefixes[countElementA - 1][Elements.AmountPrefixes[countElementA - 1].Length - 1];
                    char starting = Elements.nonMetalNamings[a.index].ToLower()[0];
                    if (ending == c)
                    {
                        for (int g = 0; g < Elements.vowels.Length; g++)
                        {
                            char ch = Elements.vowels[g];
                            if (starting == ch)
                            {
                                name += Elements.AmountPrefixes[countElementA - 1].Substring(0, Elements.AmountPrefixes[countElementA - 1].Length - 1);
                                name += Elements.nonMetalNamings[a.index].ToLower();
                                break;
                            }
                            if (g == Elements.vowels.Length - 1)
                            {
                                name += Elements.AmountPrefixes[countElementA - 1];
                                //add on element name
                                name += Elements.nonMetalNamings[a.index].ToLower();
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                name += a.name;
            }

            name += " ";

            //add on prefix
            if (countElementB <= 10 && !b.isPoly)
            {
                //check if vowel is the same
                for (int i = 0; i < Elements.vowels.Length; i++)
                {
                    char c = Elements.vowels[i];
                    char ending = Elements.AmountPrefixes[countElementB - 1][Elements.AmountPrefixes[countElementB - 1].Length - 1];
                    char starting = Elements.nonMetalNamings[b.index].ToLower()[0];
                    if (ending == c)
                    {
                        for (int g = 0; g < Elements.vowels.Length; g++)
                        {
                            char ch = Elements.vowels[g];
                            if (starting == ch)
                            {
                                name += Elements.AmountPrefixes[countElementB - 1].Substring(0, Elements.AmountPrefixes[countElementB - 1].Length - 1);
                                name += Elements.nonMetalNamings[b.index].ToLower();
                                break;
                            }
                            if (g == Elements.vowels.Length - 1)
                            {
                                name += Elements.AmountPrefixes[countElementB - 1];
                                //add on element name
                                name += Elements.nonMetalNamings[b.index].ToLower();
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                //add on element name
                name += Elements.nonMetalNamings[b.index];
            }


            //check if same element and replace with its element name
            if (a.name == b.name)
            {
                name = a.name;

                //put in HOFBRINCL
            }
            else
            {
                if (a.isPoly)
                {
                    chemicalForm += "(";
                }
                chemicalForm += a.symbol;
                if (a.isPoly)
                {
                    chemicalForm += ")";
                }
                //swap the charges
                if (countElementA > 1 && countElementA < 10)
                {
                    chemicalForm += Elements.Subscripts[countElementA - 1];
                }

                if (b.isPoly)
                {
                    chemicalForm += "(";
                }
                chemicalForm += b.symbol;
                if (b.isPoly)
                {
                    chemicalForm += ")";
                }
                //swap the charges
                if (countElementB > 1 && countElementB < 10)
                {
                    chemicalForm += Elements.Subscripts[countElementB - 1];
                }
            }

            return new(name, chemicalForm, a, b);
        }

        public static string NameMolecular(IonicMolucule molucule)
        {
            return molucule.name;
        }

        public static string ChemicalFormMolecular(IonicMolucule molucule)
        {
            return molucule.chemicalForm;
        }
    }
}
