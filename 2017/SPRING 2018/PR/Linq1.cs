using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите k");
            int k = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите колличество чисел в последовательности");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];

            Console.WriteLine("Введите последовательность");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Результат:");

            IEnumerable<int> secondFragment = numbers.Take(k);
            IEnumerable<int> firstFragment = secondFragment.Where(x => x % 2 == 0);
            int[] result = firstFragment.ToArray();
            for (var i = result.Length-1; i >= 0; i--)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
