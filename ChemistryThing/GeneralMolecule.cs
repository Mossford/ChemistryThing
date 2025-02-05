

namespace ChemistryThing
{
    public class GeneralMolecule : IMolecule
    {

        public string name { get; set; }
        //format is in main(connections(connections))
        //any element before an open bracket is deemed to be a main element where it will have anything after in the brackets connecting
        //any connection that closes the bracket will go back to the last connection to handle parts that go away from the main part of the molecule
        //example for water is O(H2)
        //example for ethane is C(H3C(H3))
        //example for 2 MethylPentane is C(H3C(HC(H3)C(H2C(H3))))
        public string format { get; set; }
        public float mass { get; set; }
        public int charge { get; set; }
        public Element[] elements { get; set; }

        public GeneralMolecule(string name, string format)
        {
            this.name = name;
            this.format = format;
            elements = ParseFormat(format);

        }
        
        public string getName()
        {
            return name;
        }

        public string getFormat()
        {
            return format;
        }

        public float getMass()
        {
            return mass;
        }

        public int getCharge()
        {
            return charge;
        }

        public Element[] getElements()
        {
            return elements;
        }


        public static Element[] ParseFormat(string format)
        {
            List<Element> elements = new List<Element>();

            int i = 0;
        
            while (i < format.Length)
            {
                if (char.IsLetter(format[i]))
                {
                    string element = "";
                    //get first letter of symbol
                    element += format[i];
                    i++;
                    
                    //check if letter after is a lower which means its part of that symbol
                    if (i < format.Length && char.IsLower(format[i]))
                    {
                        element += format[i];
                        i++;
                    }
                    
                    //then there is the count after the symbol. 1 by default
                    int count = 1;
                    if (i < format.Length && char.IsDigit(format[i]))
                    {
                        string numStr = "";
                        //get all the digits after it
                        while (i < format.Length && char.IsDigit(format[i]))
                        {
                            numStr += format[i];
                            i++;
                        }
                        count = int.Parse(numStr);
                    }
                    
                    //get the indexes of the element
                    int elementIndex = 0;
                    for (int j = 0; j < Elements.symbols.Length; j++)
                    {
                        if (element == Elements.symbols[j])
                        {
                            elementIndex = j;
                            break;
                        }
                    }
                    
                    //add the amount to the array
                    for (int j = 0; j < count; j++)
                    {
                        elements.Add(Elements.data[elementIndex]);
                    }
                }
                else
                {
                    i++;
                }
            }
            
            return elements.ToArray();
        }
        
    }
}