using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienceSorting
{
    //Стопка
    public class Patience : IEnumerable<Node>, IComparable
    {
        public Node Head { get; set; }
        public int incr { get; set; }
        //Пустая инициализация
        public Patience()
        { }


        //Инициализация по значению
        public Patience(int value)
        {
            Head = new Node(value, incr++);
        }

        //Добавить элемент в список по индексу
        public void Add(int index, int value)
        {
            var newCor = new Node(value, incr++);
            if (index == 0)
            {
                Head = newCor;
                return;
            }
            
            var previous = ReturnNode(index - 1);
            var next = previous.Next;
            previous.Next = newCor;
            newCor.Next = next;
         
        }

        //Найти и вернуть элемент в списке по индексу
        public Node ReturnNode(int index)
        {
            if (index < 0)
                return null;
            var head = Head;
            for (int i = 0; i < index; i++)
                head = head.Next;
            return head;
        }

        //Проход по всем элементам списка
        public IEnumerator<Node> GetEnumerator()
        {
            var head = Head;
            if (head != null)
            {
                while (head != null)
                {
                    yield return head;
                    head = head.Next;
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Число элементов в списке
        public int Length()
        {
            var i = 0;
            foreach (var е in this)
                i++;
            return i;
        }

        public int CompareTo(object obj)
        {
            var pile = (Patience)obj;
            return Head.Value.CompareTo(pile.Head.Value);
        }

        //первое значение в кортеже индекс, второе итерации
        public Tuple<int, int> BinarySearch(int x)
        {
            //Левая граница
            var left = 0;
            //Правая граница
            var right = Length();
            //Итерации
            var index = 0;
            //Середина рассматриваемого отрезка
            var middle = left + (right - left) / 2;
            // Если просматриваемый участок не пуст, first < last
            while (left < right)
            {
                //Сужаем рассматриваем отрезок в нужную сторону (правую/левую)
                if (x >= ReturnNode(middle).Value)
                    right = middle;
                else
                    left = middle + 1;
                middle = left + (right - left) / 2;
                //Итерация самого вложенного цикла
                index++;
            }
            return new Tuple<int, int>(middle, index);
        }
    }


}
