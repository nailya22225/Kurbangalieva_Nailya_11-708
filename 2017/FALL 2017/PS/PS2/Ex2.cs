using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps2_4
{
    class Program
    {
        static long Factorial(int f)
        {
            if (f == 0 || f == 1) return 1;
            return f * Factorial(f - 1);
        }
        static double Fun(int k)
        {
            return Math.Pow(2, k)*Math.Pow(Factorial(k),2)/ Factorial(2*k);
            
        }
        static double Fun1(double e)
        {
            double previous = 0;
            int k = 1;
            double current = Fun(k);
            double sum = current;
            k++;
            while (Math.Abs(current - previous) > e)
            {
                previous = current;
                
                current = Fun(k);
                sum += current;
                k++;
            }
            
            return sum;
        }
        static double Fun2(double e)
        {
            return (-2 + 2 * Fun1(e));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите точность e > 0,005");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine( Fun2(e));
           
        }
    }
}
