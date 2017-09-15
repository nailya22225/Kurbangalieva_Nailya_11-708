using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите прямую в виде ax+b");
            Console.WriteLine("a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координаты вектора, параллельного прямой: 1;");
            Console.WriteLine(a);
            var result = (double)-1 / a;
            Console.WriteLine("Координаты вектора, параллельного прямой: 1;");
            Console.WriteLine(result);
        }
    }
}
