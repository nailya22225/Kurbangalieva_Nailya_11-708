using System.Collections.Generic;
using System.Linq;

namespace PatienceSorting
{
    //Класс с сортировкой
    public class PatienceSort
    {
        public int index;
        //Список стопок
        private List<Patience> pations;

        //Конструктор
        public PatienceSort()
        {
            index = 0;
            pations = new List<Patience>();
            index = 0;
        }

        //Сортировка в аргументе массив целых чисел
        public List<Patience> Sort(int[] array)
        {
            //Добавление элементов
            foreach (var item in array)
                Add(item);
            return pations;
        }

        //Добавление нового элемента в список
        public void Add(int x)
        {
            //Если список пуст, добавляем в него новую стопку
            if (pations.Count == 0)
            {
                AddNewPatience(x);
            }
            var i = 0;
            i = BinarySearch(x);

            //Если -1, то идти вглубь по стопке не надо, элемент уже добавлен на вершину новой
            if (i != -1)
            {
                //Ищем подходящее место в стопке
                var tuple = pations[i].BinarySearch(x);
                //Накапливаем итерации
                index += tuple.Item2;
                //Добавляем элемент в стопку
                pations[i].Add(tuple.Item1, x);
            }
           
        }

        public int BinarySearch(int x)
        {
            //Левая граница
            var left = 0;
            //Правая граница
            var right = pations.Count;
            //Середина рассматриваемого отрезка
            var middle = left + (right - left) / 2;
            // Если просматриваемый участок не пуст, first < last
            while (left < right)
            {
                //Сужаем рассматриваем отрезок в нужную сторону (правую/левую)
                if (x < pations[middle].Head.Value)
                    right = middle;
                else
                    left = middle + 1;
                middle = left + (right - left) / 2;
            }
            //Если больше всех в предыдущих стопках, создаём новую
            if (middle >= pations.Count)
            {
                AddNewPatience(x);
                return -1;
            }
            return middle;
        }

        //Создание новой стопки по значению
        private void AddNewPatience(int x)
        {
            var queue = new Patience(x);
            //Добавление в список стопок
            pations.Add(queue);
        }

        //В массив
        public int[] ToArray()
        {
            int count = 0;
            int i = 0;
            foreach (var е in pations)
                count += е.Length();
            var array = new int[count];
            foreach (var elem in pations)
                for (int j = elem.Length() - 1; j >= 0; j--)
                    array[i++] = elem.ElementAt(j).Value;
            return array;
        }
    }
}