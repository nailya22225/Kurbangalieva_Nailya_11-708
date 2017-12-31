using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            Console.WriteLine("Вводите операции Add(x), Find(x) или End");
            while(true)
            {
                Console.WriteLine("Введите операцию");
                var operation = Console.ReadLine();
                if (operation[0] == 'A')
                {
                    var x = Convert.ToInt32(operation[4]);
                    Add(x, numbers);
                }
                if (operation[0] == 'F')
                {
                    var x = Convert.ToInt32(operation[5]);
                    Console.WriteLine(Find(x, numbers));
                }
                if (operation == "End") break;
            }
        }

        static List<int> Add(int x, List<int> numbers)
        {
            numbers.Add(x);
            Sort(numbers);
            return numbers;
        }

        static int Find(int x, List<int> numbers)
        {
            var left = 0;
            var right = numbers.Count - 1;
            while (left < right)
            {
                var middle = (right + left) / 2;
                if (x <= numbers[middle])
                    right = middle;
                else left = middle + 1;
            }
            if (numbers[right] == x)
                return right + 2;
            return -1;
        }

        static void Sort(List<int> numbers)
        {
            HoareSort(numbers, 0, numbers.Count - 1);
        }

        static void HoareSort(List<int> array, int start, int end)
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
    }
}
