using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemistryThing
{
    public static class Reactions
    {
        public static string SingleDisplacement(Element a, IonicMolucule molucule)
        {
            string rctStruct = "";
            string rctStructChem = "";

            rctStruct += a.name;
            rctStruct += " + ";
            rctStruct += molucule.name;
            rctStruct += " -> ";

            rctStructChem += a.symbol;
            rctStructChem += " + ";
            rctStructChem += molucule.chemicalForm;
            rctStructChem += " -> ";

            //create new ionic molucule by taking the other element and swapping it if it is more reactive

            if(a.isMetal)
            {
                //check if more reactive
                int aPos = -1;
                int bPos = -1;
                for (int i = 0; i < Elements.metalActivity.Length; i++)
                {
                    //check what matches
                    if(a.name == Elements.metalActivity[i])
                        aPos = i;
                    if(molucule.a.name == Elements.metalActivity[i])
                        bPos = i;
                }

                //element a is more reactive than element b and we have a reaction
                if(aPos < bPos && aPos != -1 && bPos != -1)
                {
                    //now we can swap
                    IonicMolucule newMol = NamingElements.CreateIonic(a, molucule.b);
                    rctStruct += newMol.name;
                    rctStruct += " + ";
                    rctStruct += molucule.a.name;

                    rctStructChem += newMol.chemicalForm;
                    rctStructChem += " + ";
                    rctStructChem += molucule.a.symbol;
                }
                else
                {
                    //a element is less reactive and cannot swap
                    rctStruct += "no reaction";
                    rctStructChem += "no reaction";
                }
            }
            else
            {
                //a would swap with the non metal if more reactive
                //check if more reactive
                int aPos = -1;
                int bPos = -1;
                for (int i = 0; i < Elements.nonMetalAcitivty.Length; i++)
                {
                    //check what matches
                    if(a.name == Elements.nonMetalAcitivty[i])
                        aPos = i;
                    if(molucule.b.name == Elements.nonMetalAcitivty[i])
                        bPos = i;
                }

                //element a is less reactive than element b and we have no reaction
                if(aPos > bPos && aPos != -1 && bPos != -1)
                {
                    rctStruct += "no reaction";
                    rctStructChem += "no reaction";
                }
                else
                {
                    //will assume more reactive
                    //now we can swap
                    IonicMolucule newMol = NamingElements.CreateIonic(molucule.a, a);
                    rctStruct += newMol.name;
                    rctStruct += " + ";
                    rctStruct += molucule.b.name;

                    rctStructChem += newMol.chemicalForm;
                    rctStructChem += " + ";
                    rctStructChem += molucule.b.symbol;
                }
            }

            return rctStruct + " \n" + rctStructChem;
        }

        public static string SingleDisplacement(Element a, MolecularMolucule molucule)
        {
            string rctStruct = "";
            string rctStructChem = "";

            rctStruct += a.name;
            rctStruct += " + ";
            rctStruct += molucule.name;
            rctStruct += " -> ";

            rctStructChem += a.symbol;
            rctStructChem += " + ";
            rctStructChem += molucule.chemicalForm;
            rctStructChem += " -> ";

            //create new ionic molucule by taking the other element and swapping it if it is more reactive

            if(a.isMetal)
            {
                //a element is a metal and cannot react with the molecular
                rctStruct += "no reaction";
                rctStructChem += "no reaction";
            }
            else
            {
                //a would swap with the non metal if more reactive
                //check if more reactive
                int aPos = -1;
                int bPos = -1;
                for (int i = 0; i < Elements.nonMetalAcitivty.Length; i++)
                {
                    //check what matches
                    if(a.name == Elements.nonMetalAcitivty[i])
                        aPos = i;
                    if(molucule.b.name == Elements.nonMetalAcitivty[i])
                        bPos = i;
                }

                //element a is less reactive than element b and we have no reaction
                if(aPos > bPos && aPos != -1 && bPos != -1)
                {
                    rctStruct += "no reaction";
                    rctStructChem += "no reaction";
                }
                else
                {
                    //will assume more reactive
                    //now we can swap
                    MolecularMolucule newMol = NamingElements.CreateMolecular(molucule.a, a);
                    rctStruct += newMol.name;
                    rctStruct += " + ";
                    rctStruct += molucule.b.name;

                    rctStructChem += newMol.chemicalForm;
                    rctStructChem += " + ";
                    rctStructChem += molucule.b.symbol;
                }
            }

            return rctStruct + " \n" + rctStructChem;
        }

        public static string doubleDispacement(IonicMolucule a, IonicMolucule b)
        {

            //swap the positive elements
            IonicMolucule ab = NamingElements.CreateIonic(b.a, a.b);
            IonicMolucule ba = NamingElements.CreateIonic(a.a, b.b);
        
            //check solubility if it has a reaction

            throw new NotImplementedException();
        }



        public static int[] reactionBalancer(Element[] elements, int[] elementCounts, int seperator)
        {
            //get the amounts before the seperator
            //get the amounts after the seperator
            //multiply until they equal the same amount

            List<int> firstReactants = new List<int>();
            List<int> lastReactants = new List<int>();

            for (int i = 0; i < elementCounts.Length; i++)
            {
                if(i < seperator)
                {
                    firstReactants.Add(elementCounts[i]);
                }
                else
                {
                    lastReactants.Add(elementCounts[i]);
                }
            }

            //start with any but O or H
            //get lcm of all
            throw new NotImplementedException();
        }
    }
}
