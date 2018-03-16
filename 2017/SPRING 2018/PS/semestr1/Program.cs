using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    class MainClass
    {
        public static void Main()
        {
            var polinom1 = new Polinom("input.txt");
            var polinom2 = new Polinom("input.txt");
            Console.WriteLine("polinom =" + polinom1.ToString());
            Console.WriteLine("polinom Value =" + polinom1.ValueAtPoint(1, 2, 3));
            polinom1.Derivative(2);
            Console.WriteLine("polinom Derivative Y =" + polinom1.ToString());
            polinom1.InsertElemInList(228, 3, 2, 3);
            Console.WriteLine("polinom with Insert =" + polinom1.ToString());
            polinom1.Delete(2, 2, 3);
            Console.WriteLine("polinom after Delete =" + polinom1.ToString());
            Console.WriteLine("polinom 2 =" + polinom2.ToString());
            polinom1.Summ(polinom2);
            Console.WriteLine("sum of polinoms =" + polinom1.ToString());
        }
    }
}