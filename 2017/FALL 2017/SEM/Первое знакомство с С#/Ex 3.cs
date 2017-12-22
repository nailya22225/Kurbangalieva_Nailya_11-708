using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 12)
            {
                a = a * 30;
            }
            else {if (a - 12 < 6)
                {
                    a = (a - 12) * 30;
                }
                else { a = 360 - (a - 12) * 30;
                }
            }
            Console.WriteLine(a);
        }
    }
}
