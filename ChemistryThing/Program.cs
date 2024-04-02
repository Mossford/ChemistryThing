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
            Console.WriteLine(NamingElements.NameElements(Elements.data[10], Elements.data[14]));
            Console.WriteLine(NamingElements.NameElements(Elements.data[20], Elements.data[0]));
            Console.WriteLine(NamingElements.NameElements(Elements.data[16], Elements.data[13]));

            Console.ReadLine();
        }
    }
}