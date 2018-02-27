using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество вершин");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = i;
            }
            while (true)
            {
                Console.WriteLine("Введите два числа");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                if (array[x] == array[y])
                {
                    Console.WriteLine("Такой путь уже есть");
                    continue;
                }
                for (int j = 0; j < N; j++)
                {
                    if (array[j] == array[x])
                        array[y] = array[x];
                }
                Console.WriteLine(x + " " + "-" + " " + y);
            }
        }
    }
}
