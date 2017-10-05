using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestr15
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool prost = true;
            Console.WriteLine("Задача: Найти сумму всех простых делителей заданного натурального числа (<10000)");
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= a; i++)
            {
                if (a % i == 0) { //ищем делитель числа а
                    for (int j = 2; j < i; j++) {
                        if (i % j == 0)//проверяем, является ли этот делитель простым
                        {
                            prost = false;
                            break;
                        }
                    }
                if (prost) sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Cумма всех простых делителей равна: "+ sum);
        }
    }
}
