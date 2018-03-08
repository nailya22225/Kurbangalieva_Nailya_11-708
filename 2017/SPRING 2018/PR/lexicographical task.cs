using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        public static void SortStrings(string[] array, IComparer<string> comparer)
        {
            for (int i = array.Length - 1; i > 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    var element1 = array[j - 1];
                    var element2 = array[j];
                    if (comparer.Compare(element1, element2) > 0)
                    {
                        var temporary = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temporary;
                    }
                }
        }

        class StringComparer : IComparer<string>
        {

            public int Compare(string x, string y)
            {
                return x.CompareTo(y);
            }
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var strings = new string[n];
            for (int i = 0; i < n; i++)
                strings[i]= Convert.ToString(Console.ReadLine());
            SortStrings(strings, new StringComparer());
            foreach (var e in strings)
                Console.WriteLine(e);
        }
    }
}
