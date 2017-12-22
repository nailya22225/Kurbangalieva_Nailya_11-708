using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lilili2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 100 + ((a / 10) % 10) * 10 + (a % 10) * 100;

            Console.WriteLine(b);




        }
    }
}
