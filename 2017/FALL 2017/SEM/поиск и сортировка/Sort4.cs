using System;

namespace Sort4
{
    class Program
    {
        static void Main()
        {
            var number = 0;
            var n = int.Parse(Console.ReadLine());
            var arrayN = new int[n];
            for(int i = 0; i < n; i++)
            {
                arrayN[i] = int.Parse(Console.ReadLine());
            }
            HoareSort(arrayN);
            Console.WriteLine("###");
            var k = int.Parse(Console.ReadLine());
            var arrayK = new int[k];
            for (int i = 0; i < k; i++)
            {
                arrayK[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < k; i++)
            {
                number = arrayK[i];
                Console.WriteLine(arrayN[number - 1]);
            }

        }

        static void HoareSort(int[] array, int start, int end)
        {
            if (end == start) return;
            var pivot = array[end];
            var storeIndex = start;
            for (int i = start; i <= end - 1; i++)
                if (array[i] <= pivot)
                {
                    var t = array[i];
                    array[i] = array[storeIndex];
                    array[storeIndex] = t;
                    storeIndex++;
                }

            var n = array[storeIndex];
            array[storeIndex] = array[end];
            array[end] = n;
            if (storeIndex > start) HoareSort(array, start, storeIndex - 1);
            if (storeIndex < end) HoareSort(array, storeIndex + 1, end);
        }

        static void HoareSort(int[] array)
        {
            HoareSort(array, 0, array.Length - 1);
        }
    }
}
