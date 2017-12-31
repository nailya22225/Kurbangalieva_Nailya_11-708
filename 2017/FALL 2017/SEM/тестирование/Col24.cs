using System;

namespace Col24
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (int i = 0; i < n; i++)
                array[i] = int.Parse(Console.ReadLine());
            var max = GetMaxNumber(array);
            var numbers = new List<int>();
            for(int i = 0; i < n; i ++)
                numbers.Add(i + 1);
            for(int i = 2; i < n; i++)
            {
                for(int j = i; j < n; j ++)
                {
                    if (numbers[j] % i == 0) numbers.Remove(j);
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[array[i]]);
            }
        }

        static int GetMaxNumber(int[] array)
        {
            var max = -1;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }
            return max;
        }
    }
}
