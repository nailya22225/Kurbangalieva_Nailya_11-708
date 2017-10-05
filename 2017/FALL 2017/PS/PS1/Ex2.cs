using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача: Посчитать разницу между суммой квадратов и квадратом суммы натуральных чисел от 1 до 100");
            int i;
            int sum1 = 0;//переменная для суммы квадратов
            int sum2 = 0;//переменная для квадрата суммы
            for ( i = 0; i <= 100; i++)
            { sum1 = sum1 + i * i;//находим сумму квадратов
                sum2 = sum2 + i;//находим обычную сумму
            }
            sum2 = Math.Pow(sum2, 2);//возводим сумму в квадрат
                Console.WriteLine(Math.Abs(sum2 - sum1));
        }
    }
}
