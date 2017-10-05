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
            int b = (a % 10) + ((a / 10) % 10) * 10 + ((a / 100) % 10) * 100;//находим сумму трех последних цифр
            a = a / 1000;
            а = (a % 10) + ((a / 10) % 10) * 10 + a / 100*100;//находим сумму первых трех цифр
            if (Math.Abs(b - a == 1))
                Console.WriteLine("Является");
            else 
                Console.WriteLine("Не является");
        }
    }
}
