using System;
using System.Collections.Generic;

namespace Col7
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var array = GetArray(n);
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < n; i ++)
            {
                if (dictionary.ContainsKey(array[i])) dictionary[array[i]]++;
                else dictionary.Add(array[i], 1);
            }
            Console.WriteLine(FindX(dictionary, n));
        }

        static int[] GetArray(int n)
        {
            var array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        static int FindX(Dictionary<int, int> dictionary, int n)
        {
            foreach (var count in dictionary)
            {
                if (count.Value > n / 2)
                    return count.Key;
            }
            return -1;
        }
    }
}
