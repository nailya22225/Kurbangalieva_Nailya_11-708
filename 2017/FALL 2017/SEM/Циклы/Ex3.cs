using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace семинар_циклы_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 9) Console.WriteLine(n);
            if ((n > 9) && (n <= 189))
            {
                int k = ((n - 9) / 2) + 9;
                if (n == 10) Console.WriteLine(1);
                else if (n % 2 == 0) Console.WriteLine(k/10);
                else Console.WriteLine(k%10);
            }
            if ((n > 189) && (n <= 2889))
            {
                int k = ((n - 189) / 3) + 99;
                if (n == 190) Console.WriteLine(1);
                else if (n == 191) Console.WriteLine(0);
                else if (n % 3 == 0) Console.WriteLine(k%10);
                else if (n % 3 == 2) Console.WriteLine((k / 10) % 10);
                else Console.WriteLine(k / 100);
         
            }
        }
    }
}
