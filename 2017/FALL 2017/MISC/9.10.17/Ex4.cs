using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите n количество элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            int i;
            int j;
            Console.WriteLine("Заполните массив");
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (i == j) array[i, j] = 0;
                    else if (i + j == n - 1) array[i, j] = 0;
                }
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    Console.WriteLine(array[i, j]);
        }
        
    }
}
