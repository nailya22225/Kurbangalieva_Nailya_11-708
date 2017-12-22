using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace семинар_циклы_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            while (a != 0)
            {
                s = s + a % 10;
                if (a / 10 != 0)
                {
                    s = s * 10;
                }
                a = a / 10;
            }
            Console.WriteLine(s);
        }
    }
}
