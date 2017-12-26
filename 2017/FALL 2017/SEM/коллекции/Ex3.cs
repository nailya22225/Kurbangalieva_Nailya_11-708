using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Col3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxSum = 0;
            int[] array = new int[n];
            for(int i = 0; i < n; i ++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > 0) sum += array[i];
                else sum = 0;
                if (sum >= maxSum) maxSum = sum;
            }
            Console.WriteLine(maxSum);
        }
    }
}
