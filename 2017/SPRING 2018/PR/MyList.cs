using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public int element;
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    public class LinkedList<T>// односвязный список
    {
        Node<T> head; // первый элемент
        Node<T> tail; // последний элемент
        int count;//колличество элементов
        public int Count { get { return count; } }

        // добавление элемента
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            count = 0;
            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;
            count++;
        }
        
        // удаление элемента
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    // Если удаляется элемент в середине или в конце
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        head = head.Next;

                        // если после удаления список пуст, то tail тоже равен null
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }
        //вывод содержимого списка
        public void OutputList()
        {
            if (head == null) throw new InvalidOperationException();
            Console.WriteLine(head.Data);
            while (head.Next != null)
            {
                head = head.Next;
                Console.WriteLine(head.Data);
            }

        }
        //считет колличество элементов
        public int CountElements()
        {
            int quantity = 0;
            if (head != null) quantity++;
            while (head.Next != null)
            {
                quantity++;
                head = head.Next;
            }
            return quantity;
        }
        // содержит ли список элемент
        public void Contains(T data)
        {
            int index = 1;
            Node<T> current = head;
            if (current == null) throw new InvalidOperationException();

            while (current != null)
            {
                    if (current.Data.Equals(data))
                    {
                    Console.WriteLine(index);
                    }

                    current = current.Next;
                    index++;
            }
        }
    }
    public class ListStack
    {
        LinkedList<int> list = new LinkedList<int>();
        public void Push(int value)
        {
            list.Add(value);
        }
        public bool Pop()
        {
            if (list.Count == 0) throw new InvalidOperationException();
            list.Remove(list.Count - 1);
            return true;
        }
    }
    public class ListQueue
    {
        LinkedList<int> list = new LinkedList<int>();
        public void Enqueue(int value)
        {
            list.Add(value);
        }

        public bool Dequeue()
        {
            if (list.Count == 0) throw new InvalidOperationException();
            list.Remove(0);
            return true;
        }
    }
}