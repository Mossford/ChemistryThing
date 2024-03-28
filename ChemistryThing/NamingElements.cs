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

                string temp = b.name.Substring(0, b.name.Length - 3) + "ide";
                name += " ";
                name += temp;
                return name;
            }

            return name;
        }
    }
}
