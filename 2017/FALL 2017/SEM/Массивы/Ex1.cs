using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        //можете не проверять, на паре все вместе разбирали
        static void InvertedArray(int[] arr, int begin, int end)
        {
            for (int i = 0; i < (end - begin) / 2; i++)
            {
                int c = arr[i + begin];
                arr[i + begin] = arr[end - 1 - i];
                arr[end - 1 - i] = c;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну массива");
            var n = int.Parse(Console.ReadLine());

            var arr = new int[n];
            Console.WriteLine("Вводите значения массива");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите колличесво позиций");
            var k = int.Parse(Console.ReadLine());

            InvertedArray(arr, 0, n);
            InvertedArray(arr, 0, k);
            InvertedArray(arr, k, n);

            foreach (var e in arr)
                Console.WriteLine(e + " ");
        }


    }
}