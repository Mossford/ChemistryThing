using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemistryThing
{
    public static class NamingElements
    {
        public static string NameElements(Element a, Element b)
        {
            string name = "";

            //If with a metal
            if(a.isMetal && !b.isMetal)
            {
                name += a.name;
                //swap the charges
                if(MathF.Abs(b.charge) != 1)
                    name += Elements.Subscripts[(int)MathF.Abs(b.charge) - 1];

                //add on the -ide naming
                string temp = Elements.nonMetalNamings[b.index];
                name += " ";

                name += temp;
                //swap the charges
                if(MathF.Abs(a.charge) != 1)
                    name += Elements.Subscripts[(int)MathF.Abs(a.charge) - 1];
                return name;
            }

            return name;
        }
    }
}
