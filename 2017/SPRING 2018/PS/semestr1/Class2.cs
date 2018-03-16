using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        public MyLinkedList()
        {
            var exec = new LinkedListNode<T>();
            first = last = exec;
        }

        public void AddByIndex(int index, T element)
        {
            //if (index < 0 || index > count) throw new Exception();

            if (index == 0)
            {
                LinkFirst(element);
                return;
            }

            if (index == count)
            {
                LinkLast(element);
                return;
            }

            LinkedListNode<T> newElement = new LinkedListNode<T> { Data = element, Next = null };
            LinkedListNode<T> current = first;

            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            newElement.Next = current.Next;
            current.Next = newElement;
            count++;
        }

        private void LinkFirst(T e)
        {
            LinkedListNode<T> newElement = new LinkedListNode<T> { Data = e, Next = null };

            if (IsEmpty())
            {
                first = last;
            }
            else
            {
                newElement.Next = first;
            }
            first = newElement;
            count++;
        }

        private void LinkLast(T e)
        {
            LinkedListNode<T> newElement = new LinkedListNode<T> { Data = e, Next = null };

            if (IsEmpty())
            {
                first = newElement;
            }
            else
            {
                last.Next = newElement;
            }
            last = newElement;
            count++;
        }

        public bool IsEmpty()
        {
            return Count == 0 || first.Data == null;
        }

        public void AddFirst(T item)
        {
            if (first.Data == null)
            {
                first = last = new LinkedListNode<T>();
                first.Data = item;
            }
            else
            {
                LinkedListNode<T> newEl = new LinkedListNode<T>() { Data = item };
                newEl.Next = first;
                first = newEl;
            }
            Count++;
        }

        public void AddLast(T item)
        {
            if (last == null)
            {
                first = last = new LinkedListNode<T>();
            }
            else
            {
                LinkedListNode<T> newEl = new LinkedListNode<T>() { Data = item };
                last.Next = newEl;
                last = newEl;
                Last = last;
            }
            Count++;
        }

        public LinkedListNode<T> Find(LinkedListNode<T> item) => FindElement(item);

        public void Remove(T item)
        {
            LinkedListNode<T> current = first;
            if (item.Equals(first.Data))
            {
                first = first.Next;
                count--;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (item.Equals(current.Next.Data))
                    {
                        current.Next = current.Next.Next;
                        count--;
                        break;
                    }
                    else
                    {

                        current = current.Next;
                    }
                }
            }
        }

        private LinkedListNode<T> FindElement(LinkedListNode<T> item)
        {
            var i = first;
            while (i != item)
                i = i.Next;
            return i;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public virtual IEnumerator<T> GetEnumerator()
        {
            foreach (var node in _nodes)
                yield return node.Data;
        }

        public int Count { get; private set; }
        public LinkedListNode<T> First { get; set; }
        public LinkedListNode<T> Last { get; set; }
        private LinkedListNode<T> first;
        private LinkedListNode<T> last;
        private int count;

        private IEnumerable<LinkedListNode<T>> _nodes
        {
            get
            {
                for (var current = first; current != null; current = current.Next)
                {
                    count++;
                    yield return current;
                }
            }
        }
    }

    public class LinkedListNode<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }
}