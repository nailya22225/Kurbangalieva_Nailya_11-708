using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lilili3
{
    class Program
    {
        static int f(int x, int n)
        {
            return (n - 1) / x;
        }
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            int n = b - a;
            Console.WriteLine(f(4, n) + f(100, n) - f(400, n));
            Console.ReadLine();

        }
    }
}
