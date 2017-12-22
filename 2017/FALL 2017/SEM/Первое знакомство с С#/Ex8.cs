using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите прямую в виде ах+b");
            Console.WriteLine("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки");
            Console.WriteLine("x=");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y=");
            int y = Convert.ToInt32(Console.ReadLine());
            var k = (double)-1 / a;
            var c = y - k * x;
            var x1 =(c - b) / (a + 1 / a);
            var y1 =(-x1 / a) + c;
            Console.WriteLine(x1);
            Console.WriteLine(y1);

        }
    }
}
