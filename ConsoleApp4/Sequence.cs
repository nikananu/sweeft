using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Sequence
    {
        public static bool IsProperly(string sequence)
        {
            int counter = 0;

            foreach (char c in sequence)
            {
                if (c == '(')
                {
                    counter++; // გაზარდეთ counter
                }
                else if (c == ')')
                {
                    if (counter == 0)
                    {
                        return false; // თუ counter ნულის ტოლია, მაშინ არასწორია
                    }
                    counter--; // შეამცირეთ counter
                }
            }

            return counter == 0; // თუ counter ნულის ტოლია, მიმდევრობა სწორია
        }
    }
}
