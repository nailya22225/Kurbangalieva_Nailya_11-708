using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько часов?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько минут?");
            double b = Convert.ToInt32(Console.ReadLine());
            if (a > 12) { a = a - 12;
            }
            double d = 5 * a - b;
     
            if (d<0)
            {
               d = d*-1;
            }
            double c = b / 12;
            double grad = (d - c) * 6;
            if (grad > 180)
            {
                Console.WriteLine(306 - grad);
            }
            else { Console.WriteLine(grad);
            }
        }
    }
}
