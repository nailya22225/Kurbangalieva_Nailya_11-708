using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps2_4
{
    class Program
    {
        //считает факториал
        static long Factorial(int f)
        {
            if (f == 0 || f == 1) return 1;
            return f * Factorial(f - 1);
        }

        static double Function(int k)
        {
            return Math.Pow(2, k)*Math.Pow(Factorial(k),2)/ Factorial(2*k);
            
        }
        //считает сумму
        static double Summa(double e)
        {
            double previous = 0;
            int k = 1;
            double current = Function(k);
            double sum = current;
            k++;
            while (Math.Abs(current - previous) > e)
            {
                previous = current;
                // ---check--- всё то же самое, неоптимально
                current = Function(k);
                sum += current;
                k++;
            }
            
            return sum;
        }
        //находит пи по формуле
        static double FindPi(double e)
        {
            return (-2 + 2 * Summa(e));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите точность e > 0,005");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine( FindPi(e));
           
        }
    }
}
