using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер билета");
            int s = Convert.ToInt32(Console.ReadLine()); 
            int a = s/100000+s/10000%10+s/1000%10;
            int b = s % 10 + s % 100 / 10 + s % 1000 / 100;
            Console.WriteLine(a);
            Console.WriteLine(s);
            //если cумма первых 3 цифр больше и последняя цифра билета не 9 или сумма меньше и последнее число не 0
            if (((a-b == 1) && (s%10!=9)) || ((a == -1) && (s%10!=0))) 
                Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
