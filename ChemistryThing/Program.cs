using System;
using System.Numerics;
using System.Text;
using Raylib_cs;

namespace ChemistryThing
{
    public static class Program
    {
        //Made to help study for Chemistry


        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Naming of ionic");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(NamingElements.CreateIonic(Elements.data[32], Elements.data[42]));
            Console.WriteLine(NamingElements.CreateIonic(Elements.data[20], Elements.data[0]));
            Console.WriteLine(NamingElements.CreateIonic(Elements.data[16], Elements.data[13]));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Naming of molecular");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[4], Elements.data[0]));
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[6], Elements.data[0]));
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[4], Elements.data[46]));
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[6], Elements.data[43]));
            Console.WriteLine(NamingElements.CreateMolecular(Elements.data[13], Elements.data[48]));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Single displacement with a metal");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            IonicMolucule ionicMol = NamingElements.CreateIonic(Elements.data[32], Elements.data[42]);
            Console.WriteLine(Reactions.SingleDisplacement(Elements.data[0], ionicMol));

            ionicMol = NamingElements.CreateIonic(Elements.data[20], Elements.data[0]);
            Console.WriteLine(Reactions.SingleDisplacement(Elements.data[32], ionicMol));

            ionicMol = NamingElements.CreateIonic(Elements.data[20], Elements.data[7]);
            Console.WriteLine(Reactions.SingleDisplacement(Elements.data[34], ionicMol));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Single displacement with a nonmetal");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            MolecularMolucule molecularMol = NamingElements.CreateMolecular(Elements.data[4], Elements.data[0]);
            Console.WriteLine(Reactions.SingleDisplacement(Elements.data[5], molecularMol));

            molecularMol = NamingElements.CreateMolecular(Elements.data[4], Elements.data[0]);
            Console.WriteLine(Reactions.SingleDisplacement(Elements.data[34], molecularMol));

            molecularMol = NamingElements.CreateMolecular(Elements.data[4], Elements.data[7]);
            Console.WriteLine(Reactions.SingleDisplacement(Elements.data[34], molecularMol));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Mol conversions");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //question from quiz and is correct find how many grams of sodium 2 in 4.11x10^26 atoms
            Console.WriteLine(Quantities.MassFromUnits(4.11E26, Elements.data[8], 2));


            GeneralMolecule testMolecule = new GeneralMolecule("octane", "C(H3C(C(H3)HC(H2C(H3)))))");
            

            Raylib.InitWindow(1920, 1080, "Chemistry");
            
            Renderer.Init();
            Raylib.SetTargetFPS(10000);
 
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Gray);
                
                Renderer.Render();
                ChemRendering.RenderMolecule(new Vector2(Raylib.GetRenderWidth() / 2f, Raylib.GetRenderHeight() / 2f), testMolecule);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}