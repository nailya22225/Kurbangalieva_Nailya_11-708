using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps2_3
{
    class Program
    {
        static double Function(double x, int k)
        {
            return Math.Pow(-1, k) / (Math.Pow(x, 2*k+1)*2*k+1);

        }
        static double Summa(double x, double e)
        {
            double previous = 0;
            double current = Function(x, 0);
            double sum = current;
            int k = 1;
            while (Math.Abs(current - previous) > e)
            {
                previous = current;
                current = Function(x, k);
                sum += current;
                k++;
            }
            Console.WriteLine("Точность достигается на " + k + " шагу");
            return sum;
        }
        static double Result(double x, double e)
        {
            return Math.PI * Math.Abs(x) / 2 * x - Summa(x, e);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите |x|>1");
            double x = double.Parse(Console.ReadLine());
            if ((x < 1) && (x > -1)) Console.WriteLine("Неправильно введен |x|>1");
            else
            {
                Console.WriteLine("Введите точность e");
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат равен " + Result(x, e));
            }
        }
    }
}
