using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace семинар_циклы_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            for (int a = 1; a < 9; a++)
                for (int b = 0; b < 9; b++)
                    for (int c = 0; c < 9; c++)
                        if (a + b + c == n) k++;
            Console.WriteLine(k);
        }
    }
}
