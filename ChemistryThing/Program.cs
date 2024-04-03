using System;
using System.Text;

namespace ChemistryThing
{
    public static class Program
    {
        //Made to help study for Chemistry


        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(NamingElements.CreateIonic(Elements.data[10], Elements.data[14]));
            Console.WriteLine(NamingElements.CreateIonic(Elements.data[20], Elements.data[0]));
            Console.WriteLine(NamingElements.CreateIonic(Elements.data[16], Elements.data[13]));
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[12], Elements.data[6]));
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[4], Elements.data[0]));
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[4], Elements.data[46]));
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[6], Elements.data[43]));
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[13], Elements.data[48]));

            Console.ReadLine();
        }
    }
}