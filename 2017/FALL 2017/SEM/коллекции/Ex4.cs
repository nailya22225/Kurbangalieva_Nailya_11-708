using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Col4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int m = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxSum = 0;
            for(int i = 0; i < n; i ++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < n - m; i ++)
            {
                for(int j = 0; j < m; j ++)
                {
                    sum += array[j];
                }
                if (sum > maxSum) maxSum = sum;
                sum = 0;
            }
            Console.WriteLine(sum);
        }
    }
}
