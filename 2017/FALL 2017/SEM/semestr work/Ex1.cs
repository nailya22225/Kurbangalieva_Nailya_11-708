using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestr1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер билета");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = (a % 10) + ((a / 10) % 10) * 10 + ((a / 100) % 10) * 100;
            a = a / 1000;
            int c = (a % 10) + ((a / 10) % 10) * 10 + a / 100*100;
            if ((b - c == 1) || (b - c == -1))
            {
                Console.WriteLine("Является");
            }
            else {
                Console.WriteLine("Не является");

            }

        }
    }
}
