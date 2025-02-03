using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MassiveNotContain
    {
       public static int NotContains(int[] array)
        {
           
            HashSet<int> set = new HashSet<int>(array);

            
            int minPositive = 1;
            while (set.Contains(minPositive))
            {
                minPositive++;
            }

            return minPositive;
        }
    }
}
