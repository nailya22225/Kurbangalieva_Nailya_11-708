using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar31
{
    class Program
    {
        static void TestMove1(string from, string to)
        {
            Console.WriteLine("{0}-{1} {2}", from, to, ForElephant(from, to));
        }
        static bool ForElephant(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
            if ((dx == dy) && (dx != 0))
                return true;
            else return false;
            
        }
        static void TestMove2(string from, string to)
        {
            Console.WriteLine("{0}-{1} {2}", from, to, ForHorse(from, to));
        }
        static bool ForHorse(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
            if (((dx == 2 * dy)&&(dx!=0)) || ((2 * dx == dy)&&(dx!=0)))
                return true;
            else return false;
        }
        static void TestMove3(string from, string to)
        { Console.WriteLine("{0}-{1} {2}", from, to, ForLadya(from, to));
        }
        static bool ForLadya(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
            if (((dx == 0)&&(dy!=0)) || (( dy == 0)&&(dx!=0)))
                return true;
            else return false;
        }
        static void TestMove4(string from, string to)
        {
            Console.WriteLine("{0}-{1} {2}", from, to, ForQueen(from, to));
        }
        static bool ForQueen(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
            if (((dx == 0) && (dy != 0)) || ((dx != 0) && (dy == 0)) || ((dx == dy) && (dx != 0)))
                return true;
            else return false;
        }
        static void TestMove5(string from, string to)
        {
            Console.WriteLine("{0}-{1} {2}", from, to, ForKing(from, to));
        }
        static bool ForKing(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
            if (((dx == 1) && (dy == 1))) 
                return true;
            else return false;
        }
        static void Main(string[] args)
        {
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            Console.WriteLine("Ход для слона");
            TestMove1(from, to);
            Console.WriteLine("Ход для коня");
            TestMove2(from, to);
            Console.WriteLine("Ход для ладьи");
            TestMove3(from, to);
            Console.WriteLine("Ход для ферзя");
            TestMove4(from, to);
            Console.WriteLine("Ход для короля");
            TestMove4(from, to);
        }
    }
}
