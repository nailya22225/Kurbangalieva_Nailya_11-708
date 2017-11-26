using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Random;

namespace ps2_5
{
    class Program
    {
        //сама функция
        static double Function(double r)
        {
            return Math.Pow(Math.Log(2 * Math.Sin(r)), 2);
        }
        static double LeftTriangles(double n)
        {
            double sum = 0;
            double i = 0.5;
            while (i < 2.5)
            {
                sum += 1.0/n * Function(i);
                i += 1.0/n;
            }
            return sum;
        }
        static double RightTriangles(double n)
        {
            double sum = 0;
            double i = 0.5+ 1.0/n;
            while (i <= 2.5)
            {
                sum += 1.0/n * Function(i);
                i += 1.0/n;
            }
            return sum;
        }
        static double Trapeze(double n)
        {
            double sum = 0;
            double i = 0.5;
            while (i < 2.5)
            {
                sum += 1.0/n * ((Function(i)+Function(i+ 1.0/n))/2);
                i += 1.0/n;
            }
            return sum;
        }
        //тут все по формуле
        static double Simpson(int n)
        {
            double h = 1.0 / n;// h=(b-a)/2n - шаг
            var X = new double[2*n+1];//создадим массив, элементами которого будут значения точек по оси х, 
            //т.к. в каждой итерации мы рассматриваем 3 точки, то сумма точек середины итераций и конца равна 2*n + начало 1 итерации = 2*n+1
            for (int i = 0; i <= 2 * n; i++)
            {
                X[i] = 0.5 + i * h;
            }
            double sum1 = 0;//для суммирования нечетных элементов массива
            double sum2 = 0;//для суммирования четных элементов массива
            for (int j = 1; j <= n; j++)
            {
                sum1 += Function(X[2 * j - 1]);
                sum2 += Function(X[2 * j]);
            }
            sum2 = sum2 - Function(X[2 * n]);

            return h * (Function(0.5) + 4 * sum1 + 2 * sum2 + Function(X[2 * n])) / 3;
        }
        //Рандом относится к Монте-Карло
        static double Random(double min, double max, Random random)
        {
            return random.NextDouble() * (max - min) + min;
           
        }
        static double MonteKarlo(double n)
        {
            int koll = 0;//колличество точек, у которых ордината меньше чем у функции
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                double x1 = Random(0.5, 2.5,random );
                double y1 = Random(0, 0.48, random);
                if (y1 <= Function(x1)) koll++;
            }
            n = 1.0 / n;
            return koll*n;
        }
        //просто метод для удобного вызова других методов
        static double V(int p, int n)
        {
            if (p == 1) return LeftTriangles(n);
            else if (p == 2) return RightTriangles(n);
            else if (p == 3) return Trapeze(n);
            else if (p == 4) return Simpson(n);
            else return MonteKarlo(n);

        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Выберите формулу, по которой нужно вычислить приближенное значение интеграла(напишите число).");
            Console.WriteLine("1) левых прямоугольников;");
            Console.WriteLine("2) правых прямоугольников;");
            Console.WriteLine("3) трапеций;");
            Console.WriteLine("4) Симпсона;");
            Console.WriteLine("5) Монте-Карло.");

            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число отрезков/итераций n.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(V(p, n));    
        }
    }
}
