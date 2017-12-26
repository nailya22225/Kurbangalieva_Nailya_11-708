using System;
using System.Collections.Generic;

namespace sem_a2
{
    class Program
    {
        static void Main()
        {
            var a = DoubleParse(Console.ReadLine());//основание 1 системы счисления
            var b = DoubleParse(Console.ReadLine());//основание второй системы счисления
            var number = TranslatingNumberInArray();
            var number10 = Translation10SystemСalculus(number, a);
            Console.WriteLine(GetNumberInBSystemСalculus(number10, b));
        }
        //число вводится в строке и переводится в массив
        static double[] TranslatingNumberInArray()
        {
            var n = Console.ReadLine();//само число
            var array = new int[n.Length];
            for(int i = 0; i< n.Length; i++)
            {
                array[i] = int.Parse(n[i].ToString());
            }
            return array;
        }
        //число переводится в десятичную систему счисления
        static double Translation10SystemСalculus(double[] array, double a)
        {
            double number = 0;
            double power = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                number += array[i] * Math.Pow(a, power);
                power--;
            }
            return number;
        }

        static double GetNumberInBSystemСalculus(double number10, double b)
        {
            var quotient = number10;
            var numberB = new List<double>();
            while(quotient > 1)
            {
                numberB.Add(quotient % b);
                quotient /= b;
            }
            numberB.Add(quotient);
            numberB.Reverse();
            return GetNumber10(numberB.ToArray(), 10);
        }
    }
}
