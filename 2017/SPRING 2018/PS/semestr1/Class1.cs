using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    class Syllable : IComparable<Syllable>
    {
        public int Coefficient { get; set; }
        public int PowerX { get; set; }
        public int PowerY { get; set; }
        public int PowerZ { get; set; }

        public Syllable(int k, int x, int y, int z)
        {
            Coefficient = k;
            PowerX = x;
            PowerY = y;
            PowerZ = z;
        }

        
        //производная по i переменной
        public void GetDerivative(int i)
        {
            switch (i)
            {
                case 1:
                    if (PowerX > 0)
                    {
                        Coefficient *= PowerX;
                        PowerX--;
                    }
                    else Coefficient = 0;
                    break;
                case 2:
                    if (PowerY > 0)
                    {
                        Coefficient *= PowerY;
                        PowerY--;
                    }
                    else Coefficient = 0;
                    break;
                case 3:
                    if (PowerZ > 0)
                    {
                        Coefficient *= PowerZ;
                        PowerZ--;
                    }
                    else Coefficient = 0;
                    break;
            }
        }
        //проверяет существует ли подобный элемент для вставки
        public bool CheckForReplace(int newX, int newY, int newZ) => newX == PowerX && newY == PowerY && newZ == PowerZ;
        //при сложении проверяет существует ли элемент с такими же степенями 
        public bool CheckForSum(Syllable another) => another.PowerX == PowerX && another.PowerY == PowerY && another.PowerZ == PowerZ;
        //значение полинома в точке
        public int ValueAtPoint(int x, int y, int z) => Coefficient * Power(x, PowerX) * Power(y, PowerY) * Power(z, PowerZ);
        //возводит число в степень(для ValueAtPoint)
        private int Power(int number, int power)
        {
            var temp = 1;
            if (power == 0) return 1;
            for (int i = 1; i <= power; i++)
                temp *= number;
            return temp;
        }
        public int GetSumPowers() => PowerX + PowerY + PowerZ;

        public int CompareTo(Syllable other)
        {
            if (this.PowerX == other.PowerX && this.PowerY == other.PowerY) return other.PowerZ - this.PowerZ;
            else if (this.PowerX == other.PowerX) return other.PowerY - this.PowerY;
            else return other.PowerX - this.PowerX;
        }
        //декодирование
        public override string ToString() => String.Format("{0}*x^{1}*y^{2}*z^{3}", Coefficient, PowerX, PowerY, PowerZ);
    }
}

