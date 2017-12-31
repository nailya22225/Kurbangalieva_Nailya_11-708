using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s36
{
class Program
    {
        static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            double vektor1 = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            double vektor2 = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
            double vektor3 = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));
            if ((vektor1 == vektor2) && (vektor3 == vektor1 * Math.Sqrt(2)))
            {
                Console.WriteLine("Точки являются вершинами квадрата");
            }
            else if ((vektor1 == vektor3) && (vektor2 == vektor1 * Math.Sqrt(2)))
            {
                Console.WriteLine("Точки являются вершинами квадрата");
            }
            else if ((vektor2 == vektor3) && (vektor1 == vektor2 * Math.Sqrt(2)))
            {
                Console.WriteLine("Точки являются вершинами квадрата");
            }
            else
            { 
                Console.WriteLine("Точки не являются вершинами квадрата");
            }
        }
    }
}
