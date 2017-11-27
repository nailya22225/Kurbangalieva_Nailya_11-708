using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps2_2
{
    class Program
    {
        static int k;
        //считает факториал
        static long Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * Factorial(n - 1);
        }
        //сама функция
        static double Function(double x, int k)
        {
            return Math.Pow(x, k) / Factorial(k);

        }
        //считает сумму
        static double Summa(double x, double e)
        {
            double previous = 0;
            double current = Function(x, 0);
            double sum = current;
            k=1;
            while (Math.Abs(current - previous) > e)
            {
                previous = current;
                current = Function(x, k);
                sum += current;
                k++;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите точность e");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine("Сумма последовательности равна "+Summa(x,e));
            Console.WriteLine("Точность достигается на "+k+" шагу");
        }
    }
}
