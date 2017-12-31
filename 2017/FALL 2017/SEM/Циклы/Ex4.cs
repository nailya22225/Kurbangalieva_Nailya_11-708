using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int lastNumber = 0;
            int k = 0;
            for(int i = 0; i < number; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if(x == lastNumber || k == 0)
                {
                    lastNumber = x;
                    k++;
                }
            }
            Console.WriteLine(k);
        }
    }
}
