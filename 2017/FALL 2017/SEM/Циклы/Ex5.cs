using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminars
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            int depth = 0; 
            int maxDepth = 0;  
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(') depth++;
                if (depth > maxDepth) maxDepth = depth;
                if (str[i] == ')') depth--;

            }
            if (depth == 0)
                Console.WriteLine("Корректен, максимальная глубина: " + maxDepth);
            else Console.WriteLine("Не корректен");

        }
    }
}