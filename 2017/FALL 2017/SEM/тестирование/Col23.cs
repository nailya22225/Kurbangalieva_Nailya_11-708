using System;

namespace Col23
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            var x = int.Parse(Console.ReadLine());
            var numbers = FindNumbers(array, x);
            if (numbers.Item1 == -1) Console.WriteLine("Numbers don't exist");
            else Console.WriteLine("{0} + {1} = {2}", numbers.Item1, numbers.Item2, x);


        }

        static Tuple<int, int> FindNumbers(int[] array, int x)
        {
            var n = array.Length;
            if (x <= array[n / 2])
            {
                for (int i = 0; i < n / 2; i++)
                {
                    for (int j = n / 2; j > i; j--)
                    {
                        if (array[i] + array[j] == x)
                            return new Tuple<int, int>(array[i], array[j]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < n / 2; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (array[i] + array[j] == x)
                            return new Tuple<int, int>(array[i], array[j]);
                    }
                }
            }
            return new Tuple<int, int>(-1, -1);
        }
    }
}
