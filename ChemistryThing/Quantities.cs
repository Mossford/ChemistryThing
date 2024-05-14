using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemistryThing
{
    public static class Quantities
    {
        //Convert amount of anything into mass in grams
        public static double MassFromUnits(double amountUnits, IElement chemical)
        {
            float molMass = chemical.getMass();
            double mols = molMass / 6.02E23;
            double mass = mols * amountUnits;
            return mass;
        }

        //Convert mass of anyhting into units of anything
        public static double UnitsFromMass(double Mass, IElement chemical)
        {
            float molMass = chemical.getMass();
            double mols = Mass / molMass;
            double amount = mols * 6.02E23;
            return amount;
        }


        //Convert amount of any element with a count of it into mass in grams
        public static double MassFromUnits(double amountUnits, Element element, uint count)
        {
            float molMass = element.getMass() * count;
            double mols = molMass / 6.02E23;
            double mass = mols * amountUnits;
            return mass;
        }

        //Convert mass of any element with a count into amount of that element
        public static double UnitsFromMass(double Mass, Element element, uint count)
        {
            float molMass = element.getMass() * count;
            double mols = Mass / molMass;
            double amount = mols * 6.02E23;
            return amount;
        }
    }
}
