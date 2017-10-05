using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestr14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;//число которое вводится с экрана
            int max = 0;//максимальное
            int k=1;//колличество максимальных чисел
            Console.WriteLine("Задача: Считывая числа пока не встретится 0, найти максимальное число и сколько раз оно встречается в последовательности");
            Console.WriteLine("Вводите числа(последнее число должно быть 0)");
            while (true)
            {
                i = Convert.ToInt32(Console.ReadLine());
                if (i == 0) break;
                if (i > max) max = i;
                else if (i==max) k++;
            }
            Console.WriteLine("Максимальное число: "+ max);
            Console.WriteLine("Колличество максимальных чисел "+ k);


        }
    }
}
