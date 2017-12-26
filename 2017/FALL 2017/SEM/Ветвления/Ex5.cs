using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cond5
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double tMax = 0;
            var tMin = (l / k) * h;
            if (l % k != 0) tMax = (1 + (l / k)) * h;
            else tMax = tMin;
            Console.WriteLine($"{tMin} {tMax}");
        }
    }
}
