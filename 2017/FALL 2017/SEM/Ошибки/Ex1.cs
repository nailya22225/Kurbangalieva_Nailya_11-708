using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar21
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;

            for (int i = 1; i < 1000; i++)
            {
                if ((i % 5 == 0) || (i % 3 == 0))
                { sum += i;
                }
            }
            Console.WriteLine(sum);


        }
    }
}
