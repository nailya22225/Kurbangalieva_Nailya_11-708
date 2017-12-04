using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestr16
{
    class Program
    {
	// ---check--- надо было немного подумать и посомтреть, чему же равняется эта сумма. По сути не надо было считать сумму, достаточно было определить по какому правилу результат получается, как он зависит от n
        static void Main(string[] args)
        {
            Console.WriteLine("Задача: По заданному n (от 0 до 100) найти сумму всех n-значных чисел");
            Console.WriteLine("Введите число n");
            double n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            //Math.Pow(10,(n-1))-минимальное n-значное число, например, если число 3-значное, то минимальное=Math.Pow(10,(3-1))=10^2=100
            //Math.Pow(10,n)-1 -максимальное n-значное число, например, если число 3-значное, то максимальное=Math.Pow(10,3)-1=1000-1=999
            for (double min = Math.Pow(10, (n - 1)); min < Math.Pow(10, n); min++) {
                sum += min;
            }
            Console.WriteLine(sum);
        }
    }
}
