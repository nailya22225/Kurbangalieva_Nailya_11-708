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
            Console.WriteLine("введите количество элементов массива");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] array;
            array = new int[count];
            Console.WriteLine("Заполните массив из " + count + " элементов");
            int i = 1;
            int s = 0;
            while (s != count)
            {
                if (i >= count)
                {
                    i = i - count;
                }
                array[i] = Convert.ToInt32(Console.ReadLine());
                i++;
                s++;
            }
            for (i = 0; i < count; i++)
                Console.WriteLine(array[i]);
        }
    }
}
