using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x1 точки= ");
            Double x1 = Convert.ToInt32(Console.ReadLine());//координата "x" у точки
            Console.WriteLine("y1 точки= ");
            Double y1 = Convert.ToInt32(Console.ReadLine());//координата "y" у точки
            Console.WriteLine("x2 прямой= ");
            Double x2 = Convert.ToInt32(Console.ReadLine());//координата "x" для прямой
            Console.WriteLine("y2 прямой= ");
            Double y2 = Convert.ToInt32(Console.ReadLine());//координата "у" для прямой
            Console.WriteLine("x3 прямой= ");
            Double x3 = Convert.ToInt32(Console.ReadLine());//еще одна координата "х" для прямой
            Console.WriteLine("y3 прямой= ");
            Double y3 = Convert.ToInt32(Console.ReadLine());//еще одна координата "у" для прямой
            Double a = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));//находим длину прямой
            Double b = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));//находим расстояние от точки до одного конца прямой
            Double c = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));//находим расстояние от точки до другого конца прямой
            Double p = (a + b + c) / 2;//находим полупериметр
            Double H = (2 * (Math.Sqrt(p * (p - a) * (p - b) * (p - c)))) / a;//подставляем все под формулу для нахождения высоты
            Console.WriteLine(H);

        }
    }
}
