using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            array = new int[2];
            array[0] = 1;
            array[1] = 2;
            int temp;
            temp = array[0];
            array[0] = array[1];
            array[1] = temp;
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
        }
    }
}
