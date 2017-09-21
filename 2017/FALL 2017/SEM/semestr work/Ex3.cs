using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestr3
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 1;
            int s = 0;
            Console.WriteLine("Введите число");//это число будет переводится в двоичную систему
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число, на которое надо будет поделить");
            int k = Convert.ToInt32(Console.ReadLine());
            while (a != 0) {
                s = a % 2 * r + s;
                r = r * 10;
                a = a / 2;
            }
            if (s % k == 0)
            {
                Console.WriteLine("Делится");
            }
            else {
                Console.WriteLine("Не делится");
            }
        }
    }
}
