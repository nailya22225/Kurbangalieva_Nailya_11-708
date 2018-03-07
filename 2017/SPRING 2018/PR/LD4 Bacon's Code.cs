using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        // ищет подстроку в строке и возвращает их колличество
        private static int IndexOf(string text, string substring)
        {
            if (text.Length < substring.Length) return -1;
            var count = 0;
            long prime = 1000;
            long maxPower = 1;
            for (int i = 0; i < substring.Length - 1; i++)
                maxPower *= prime;

            long substringHash = 0;
            long hash = 0;
            for (int i = 0; i < substring.Length; i++)
            {
                hash = hash * prime + text[i];
                substringHash = substringHash * prime + substring[i];
            }

            for (int i = substring.Length; i < text.Length; i++)
            {
                if (hash == substringHash)
                {
                    bool equals = true;
                    for (int j = 0; j < substring.Length; j++)
                        if (text[i - substring.Length + j] != substring[j])
                        {
                            equals = false;
                            break;
                        }
                    if (equals) count++;
                }
                var lastLetterHash = maxPower * text[i - substring.Length];
                hash -= lastLetterHash;
                hash = hash * prime + text[i];
            }
            return count;
        }

        
        static void Main(string[] args)
        {
            int koll = 3;// общее колличество подстрок, колличество подстрок в любой строке как минимум равна 3,
            //так как шифр состроит из 2 букв, то каждая буква представляет собой подстроку и вся строка тоже является подстрокой
            int concurrences = 0;
            string str = Convert.ToString(Console.ReadLine());
            int lenghtOfString = str.Length;
            int lenghtOfText = lenghtOfString - 1;
            if (lenghtOfString == 1) Console.WriteLine(1);
            else
            {

                for (int i = 2; i < lenghtOfString; i++)
                {
                    for (int j = 0; j < lenghtOfString - i; j++)
                    {
                        string substring = str.Substring(j, i);
                        string text = str.Substring(j + 1, lenghtOfText);
                        lenghtOfText--;
                        concurrences += IndexOf(text, substring);

                    }
                    lenghtOfText = lenghtOfString - 1;

                    koll += str.Length + 1 - i - concurrences;
                    concurrences = 0;
                }
                Console.WriteLine(koll);
            }
        }
    }
}
