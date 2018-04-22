using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_sort
{
    class Node
    {
        //key - корень дерева
        int Key;
        //правая ветвь
        Node Right;
        //левая ветвь
        Node Left;

        //Создаем дерево
        public static Node NewNode(int item)
        {
            Node temp = new Node();
            temp.Key = item;
            temp.Left = temp.Right = null;
            return temp;
        }

        //Дрбавляем отсортированные элементы в массив
        public static void StoreSorted(Node root, int[] arr, ref int i)
        {
            if (root != null)
            {
                StoreSorted(root.Left, arr,ref i);
                arr[i++] = root.Key;
                StoreSorted(root.Right, arr,ref i);
            }
        }
        //Добавляем элемент в дерево
        public static Node Add(Node node, int key)
        {
            //Если дерево пустое, возвращается новый узел
            if (node == null) return NewNode(key);

            //Если элемент меньше добавляем его в левое дерево, если больше, то в правое
            if (key < node.Key)
                node.Left = Add(node.Left, key);
            else if (key > node.Key)
                node.Right = Add(node.Right, key);

            //Вернуть указатель (без изменений) узла
            return node;
        }
        //Создаем дерево по исходному массиву
        public static void TreeSort(int[] arr, int n)
        {
            Node root = null;

            //Добавляем все элементы массива в дерево
            root = Add(root, arr[0]);

            for (int j = 1; j < n; j++)
                Add(root, arr[j]);

            int i = 0;
            //Сортируем массив
            StoreSorted(root, arr, ref i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = File.ReadAllLines("RandomData.txt").Select(x => int.Parse(x)).ToArray();
            int n = array.Length;
            var stop = new Stopwatch();
            stop.Start();
            Node.TreeSort(array, n);
            stop.Stop();
            Console.WriteLine(stop.Elapsed.TotalMilliseconds);
            for (int i = 0; i < n; i++)
                Console.WriteLine( array[i]);
        }
    }
}
