using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class CountVariant
    {
        public static int CountVariants(int stairCount)
        {
            if (stairCount == 0 || stairCount == 1)
            {
                return 1;
            }

            int prev1 = 1; // CountVariants(n-1)
            int prev2 = 1; // CountVariants(n-2)

            for (int i = 2; i <= stairCount; i++)
            {
                int current = prev1 + prev2;
                prev2 = prev1;
                prev1 = current;
            }

            return prev1;
        }
    }
}
