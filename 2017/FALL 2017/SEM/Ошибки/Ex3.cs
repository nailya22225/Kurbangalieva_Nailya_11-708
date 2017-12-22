using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите через пробел целые числа h, t, v, x (5 000 <= h <= 12 000; 50 <= t <= 1 200; 1 <= x < v <= 100; h <= t · v).");
            string meanings = Console.ReadLine();
            string[] meaning = meanings.Split(' ');              

            double h = double.Parse(meaning[0]);                  
            double t = double.Parse(meaning[1]);
            double v = double.Parse(meaning[2]);
            double x = double.Parse(meaning[3]);

            double max = t;
            double min = (double)((h - x * t) / (v - x));

            if (h / x <= t)
            {
                min = 0.0;
                max = h / x;
            }

            Console.WriteLine(min+ " " + max);
        }

    }
}
