using System.Numerics;
using Raylib_cs;

namespace ChemistryThing
{
    public static class ChemRendering
    {
        public static void RenderMolecule(Vector2 position, GeneralMolecule molecule)
        {
            //Raylib.DrawText(molecule.name, (int)position.X, (int)position.Y, 40, Color.White);
            
            //go through elements
            //if main element keep index in a stack
            //go in a top counter clockwise to go right to left
            //go in a top clockwise to go left to right
            //if branch off (reach closed bracket) go back to index from stack before and do check

            Stack<int> mainElementsIndexes = new Stack<int>();
            Vector2 pastMainPosition = Vector2.Zero;
            Vector2 currentPosition = position;
            int dir = 0;
            int i = 0;
        
            while (i < molecule.format.Length)
            {
                
                if (char.IsLetter(molecule.format[i]))
                {
                    string element = "";
                    //get first letter of symbol
                    element += molecule.format[i];
                    i++;
                    
                    //check if letter after is a lower which means its part of that symbol
                    if (i < molecule.format.Length && char.IsLower(molecule.format[i]))
                    {
                        element += molecule.format[i];
                        i++;
                    }
                    
                    //then there is the count after the symbol. 1 by default
                    int count = 1;
                    if (i < molecule.format.Length && char.IsDigit(molecule.format[i]))
                    {
                        string numStr = "";
                        //get all the digits after it
                        while (i < molecule.format.Length && char.IsDigit(molecule.format[i]))
                        {
                            numStr += molecule.format[i];
                            i++;
                        }
                        count = int.Parse(numStr);
                    }

                    //Console.WriteLine(element + " " + count + " " + dir);
                    
                    //if we get a main element then switch positions
                    if (molecule.format[i] == '(')
                    {
                        switch (dir)
                        {
                            case 0:
                                currentPosition += -Vector2.UnitY * 40;
                                break;
                            case 1:
                                currentPosition += Vector2.UnitX * 40;
                                break;
                            case 2:
                                currentPosition += Vector2.UnitY * 40;
                                break;
                            case 3:
                                currentPosition += -Vector2.UnitX * 40;
                                break;
                        }
                        DrawElement(Vector2.Zero, currentPosition, element);

                        dir = 0;
                    }
                    else 
                    {
                        //go through each element
                        for (int j = 0; j < count; j++)
                        {
                            Vector2 direction = Vector2.Zero;

                            while (dir < 4)
                            {
                                switch (dir)
                                {
                                    case 0:
                                        direction = -Vector2.UnitY;
                                        break;
                                    case 1:
                                        direction = Vector2.UnitX;
                                        break;
                                    case 2:
                                        direction = Vector2.UnitY;
                                        break;
                                    case 3:
                                        direction = -Vector2.UnitX;
                                        break;
                                }

                                dir++;
                                if (direction * 40 + currentPosition != pastMainPosition)
                                {
                                    DrawElement(direction, currentPosition, element);
                                    break;
                                }
                            }

                            if (j >= dir)
                            {
                                DrawError(direction * 40 + currentPosition);
                            }
                        }
                        pastMainPosition = currentPosition;
                    }
                }
                else
                {
                    //check if we will have a main element
                    if (molecule.format[i] == '(')
                    {
                        //the element before was a main element
                        mainElementsIndexes.Push(i + 1);
                    }
                    
                    //check if we need to go back
                    if (molecule.format[i] == ')')
                    {
                        //change the position we go to but the parser will still go forward as thats the next main element we need to go to
                        
                    }

                    i++;
                }
            }
        }

        static void DrawElement(Vector2 dir, Vector2 position, string element)
        {
            Vector2 tempPos = (dir * 40) + position;
            Raylib.DrawText(element, (int)tempPos.X, (int)tempPos.Y, 20, Color.White);
            //Raylib.DrawText(dir.ToString(), (int)dir.X * 38 + (int)position.X, (int)dir.Y * 40 + (int)position.Y, 10, Color.Red);
            //Raylib.DrawText(position.ToString(), (int)dir.X * 38 + (int)position.X, (int)dir.Y * 38 + (int)position.Y, 10, Color.Green);
        }

        static void DrawError(Vector2 position)
        {
            Raylib.DrawText("Element could not be placed here\n (Probably error with the format)", (int)position.X, (int)position.Y, 25, Color.Red);
        }
    }
}