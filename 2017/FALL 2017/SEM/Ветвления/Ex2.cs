using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar32
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (x > y)
            {
                int c = x;
                x = y;
                y = c;
            }
            if (y > z) 
            {
                int c = y;
                y = z;
                z = c;
            }

            Console.WriteLine((a <= (Math.Min(a, b)) && b <= (Math.Max(a, b))));

        }
    }
}
