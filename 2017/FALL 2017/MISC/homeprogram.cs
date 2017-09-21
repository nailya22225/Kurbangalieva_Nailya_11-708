using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int d = 1;
            while (a != 0)
            {
                c = c + d * (b % 10);
                b = b / 10;
                d = d * 10;
                c = c + d * (a % 10);
                d = d * 10;
                a = a / 10;
            }
            Console.WriteLine(c);

        }
    }
}
