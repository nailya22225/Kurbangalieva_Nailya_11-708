using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество вершин");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];//массив который хранит ссылки на корень/предыдущий элемент
            int[] size = new int[N];//массив который хранит число вершин, состоящих в дереве
            for (int i = 0; i < N; i++)
            {
                array[i] = i;
                size[i] = 1;
            }
            while (true)
            {
                Console.WriteLine("Введите два числа");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                int x1 = x;
                int y1 = y;
                while (x1 != array[x1])//если вершина x не является корнем
                {
                    array[x1] = array[array[x1]];//меняем ее ссылку
                    //теперь она укзывает на предпредыдущий элемент
                    x1 = array[x1];//ищет корень
                }
                while (y1 != array[y1])//аналогично с вершиной y
                {
                    array[y1] = array[array[y1]];
                    y1 = array[y1];
                }
                if (x1 != y1)//если у двух вершин разные корни, они не связны, выводим пару
                {
                    Console.WriteLine(x + " " + "-" + " " + y);
                    //сравниваем деревья, чтобы к большему присоеденить меньшее
                    if (size[x1] < size[y1])//если дерево с вершиной x меньше,
                    { 
                        array[x1] = y1;//тогда корень этого дерева ссылается на корень большего дерева
                        size[y1] += size[x1];//размер дерева увеличивается
                    }
                    else
                    {//если дерево с вершиной x больше или равно дерева с вершиной у,
                        array[y1] = x1;//то корень дерева с вершиной у
                        //ссылается на корень дерева с вершиной х
                        size[x1] += size[y1];//размер так же увеличивается
                    }
                }
                else Console.WriteLine("Такой путь уже есть");
            }
        }
    }
}
