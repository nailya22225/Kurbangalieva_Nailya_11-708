using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestr2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum1 = 0;
            int sum2 = 0;
            for ( i = 0; i <= 100; i++)
            { sum1 = sum1 + i * i;
                sum2 = sum2 + i;
            }
            if (sum1 - sum2 * sum2 < 0) {
                Console.WriteLine(sum2 * sum2 - sum1);
            }
            else {
                Console.WriteLine(sum1 - sum2 * sum2);
            }

            
        }
    }
}
