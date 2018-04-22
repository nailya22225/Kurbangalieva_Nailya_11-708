using System;
namespace PatienceSorting
{
    //ячейка в связной стопке
    public class Node
    {
        //значение
        public int Value { get; set; }
        public int Number { get; set; }

        //ссылка на следующую ячейку
        public Node Next { get; set; }

        //инициализация
        public Node(int value, int numder)
        {
            Value = value;
            Number = numder;
        }
    }
}
