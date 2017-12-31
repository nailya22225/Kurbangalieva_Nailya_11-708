using System;

namespace Arr5
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = GetNumbers();
            var a = numbers.Item1 / numbers.Item2;
            var b = GetB(numbers);
            Console.WriteLine("{0} / {1} = {2}.{3}", numbers.Item1, numbers.Item2, a, b);
        }

        static Tuple<int, int> GetNumbers()
        {
            var n = Console.ReadLine();
            var array = n.Split('/');
            return new Tuple<int, int>(int.Parse(array[0]), int.Parse(array[1]));
        }

        static int GetB(Tuple<int, int> numbers)
        {
            var array = new int[5];
            var a = numbers.Item1;
            for (int i = 0; i < 5; i++)
            {
                if (a < numbers.Item2) a *= 10;
                array[i] = a / numbers.Item2;
                a %= numbers.Item2;
            }
            return GetNumber(array);
        }

        static int GetNumber(int[] array)
        {
            double number = 0;
            double power = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                number += array[i] * Math.Pow(10.0, power);
                power--;
            }
            return (int)number;
        }
    }
}
