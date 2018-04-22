using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortList
{
    class Program
    {
        //Делит на части
        static void Partition(Node head, ref Node front, ref Node back)
        {
            Node fast;
            Node slow;

            if (head == null || head.Next == null)
            {
                front = head; 
                back = null;
            }
            else
            {
                slow = head;
                fast = head.Next;
                while (fast != null)
                {
                    fast = fast.Next;
                    if (fast != null)
                    {
                        slow = slow.Next;
                        fast = fast.Next;
                    }
                }
                front = head; 
                back = slow.Next;
                slow.Next = null;
            }
        }

        //"Сливает" подмасиивы - переставляет ссылки элементов
        static Node MergeLists(Node a, Node b)
        {
            Node mergedList;
            if (a == null)
                return b;
            else if (b == null)
                return a;

            if (a.Value <= b.Value)
            {
                mergedList = a;
                mergedList.Next = MergeLists(a.Next, b);
            }
            else
            {
                mergedList = b;
                mergedList.Next = MergeLists(a, b.Next);
            }
            return mergedList;
        }
        //Основное тело сортировки
        public static void MergeSort(ref Node source)
        {
            var head = source;
            Node a = null;
            Node b = null;
            //Если элементов нет или есть только 1, возвращаемся
            if (head == null || head.Next == null)
                return;

            Partition(head, ref a, ref b);

            MergeSort(ref a);
            MergeSort(ref b);

            source = MergeLists(a, b);
        }

        public static void Main()
        {
            MyLinkedList list = new MyLinkedList();
            var array = File.ReadAllLines("RandomData.txt").Select(x => int.Parse(x)).ToArray();
            foreach (var e in array)
                list.Add(e);
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine(list);
            MergeSort(ref list.Root);
            stopWatch.Stop();
            Console.WriteLine(stopWatch);
            Console.WriteLine(list);
        }
    }

    class Node
    {
        //Значение элемента
        public int Value { get; set; }
        //Ссылка на следующий
        public Node Next { get; set; }
    }

    class MyLinkedList
    {
        //Начало
        public Node Root;
        //Конец
        private Node Tail;

        //Добавить новый элемент
        public void Add(int value)
        {
            var node = new Node { Value = value };
            if (Root == null)
                Root = Tail = node;
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }
        //В строку
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            var current = Root;
            while (current != null)
            {
                result.Append($"{current.Value} ");
                current = current.Next;
            }
            return result.ToString();
        }
    }
}
