using System;

namespace Search3
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine()); 
            var lens = GetArray(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(lens[i]);
            }
            Console.WriteLine(Cut(lens, k));
        }

        static int[] GetArray(int n)
        {
            var lens = new int[n];
            Random random = new Random();
            for(int i = 0; i < n; i++)
            {
                lens[i] = random.Next();
            }
            return lens;
        }

        static int Cut(int[] lens, int k)
        {
            var min = int.MaxValue;
            for(int i = 0; i < lens.Length; i++)
            {
                if (lens[i] < min) min = lens[i];
            }
            return Test(lens, min, k); 
        }

        static int Test(int[] lens, int min, int k)
        {
            if (min == 0) return -1;
            var stop = true;
            var sum = 0;
            for (int i = 0; i < lens.Length; i++)
            {
                if (lens[i] % min != 0) stop = false;
                sum += lens[i] / min;
            }
            if (stop && sum == k) return min;
            return Test(lens, min - 1, k);
        }
    }
}
