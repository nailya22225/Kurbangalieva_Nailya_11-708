using System;

namespace Search1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var data = new int[n];
            HoareSort(data);
            var index = FindIndexByBinarySearch(data, x);
            Console.WriteLine(index);
        }
        static void HoareSorts(int[] array, int start, int end)
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
            if (storeIndex > start) HoareSorts(array, start, storeIndex - 1);
            if (storeIndex < end) HoareSorts(array, storeIndex + 1, end);
        }

        static void HoareSort(int[] array)
        {
            HoareSorts(array, 0, array.Length - 1);
        }

        static int FindIndexByBinarySearch(int[] array, int element)
        {
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                var middle = (right + left) / 2;
                if (element <= array[middle])
                    right = middle;
                else left = middle + 1;
            }
            if (array[right] == element)
                return right;
            return -1;
        }
    }
}