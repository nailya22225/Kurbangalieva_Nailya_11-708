using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите через пробел длину стороны огорода и длину верёвки в метрах");
            string meanings = Console.ReadLine();
            string[] meaning = meanings.Split(' ');                      
            double a = double.Parse(meaning[0]);                      
            double lengthOfRope = double.Parse(meaning[1]);
            double s = 0;

            if (lengthOfRope > (a * Math.Sqrt(2.0)))                        
            {
                s = Math.Pow(a, 2.0);                                    
            }
            else if (lengthOfRope > (a / 2.0))
            {
                double angle = 2.0 * (Math.Acos(1 - (lengthOfRope - (a / 2.0)) / lengthOfRope));        

                s = (Math.Pow(lengthOfRope, 2.0) * (angle - Math.Sin(angle))) / 2.0;                  
                s = Math.PI * Math.Pow(lengthOfRope, 2.0) - 4 * s;
            }
            else
            {
                s = Math.PI * Math.Pow(lengthOfRope, 2.0);
            }

            Console.WriteLine(s);
        }
    }
}
