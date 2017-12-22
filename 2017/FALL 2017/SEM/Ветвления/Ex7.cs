using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar36
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var n = double.Parse(Console.ReadLine());

            if (x <= y) Console.WriteLine(0);
            else Console.WriteLine(Math.Ceiling((x * n - y * n) / (y - 1)));
        }
    }
}