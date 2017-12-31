using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Col5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int[] array1 = new int[n1];
            int n2 = int.Parse(Console.ReadLine());
            int[] array2 = new int[n2];
            int k = 0;
            bool stop = false;
            for(int i = 0; i < n1; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n2; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < n1; i ++)
            {
                for(int j = 0; j < n2; j++)
                {
                    if (array1[i + j] == array2[j]) k++;
                    if (k == n2) stop = true;
                }
                if (stop) break;
                k = 0;
            }
            if (k == n2) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
