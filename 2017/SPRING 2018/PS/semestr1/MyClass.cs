using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PS1
{
    class Polinom
    {
        MyLinkedList<Syllable> syllables = new MyLinkedList<Syllable>() { };
        //делает из строки массив коэффицентов и степеней! списка полинома, а потом переделывает этот массив в другой, где в ячейке находится элемент класса Syllable
        private Syllable[] Convert(string str)
        {
            string[] array = str.Split(' ');
            int[] intArr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                intArr[i] = int.Parse(array[i]);
            int c = 0;
            var list = new Syllable[intArr.Length / 4];
            while (true)
            {
                if (c >= intArr.Length / 4) break;
                list[c] = (new Syllable(intArr[c * 4], intArr[4 * c + 1], intArr[4 * c + 2], intArr[4 * c + 3]));
                c++;
            }
            return list;
        }
        //считывает с файла
        public Polinom(string filename)
        {
            foreach (string line in File.ReadLines(filename))
            {
                Syllable[] syll = Convert(line);
                for (int i = 0; i < syll.Length; i++)
                {
                    InsertElemInList(syll[i].Coefficient, syll[i].PowerX, syll[i].PowerY, syll[i].PowerZ);
                }
            }
        }

        public Polinom() { }
        //тут есть ошибка, тесты не проходит из-за него
        public override string ToString()
        {
            StringBuilder strInterpretation = new StringBuilder();
            
            foreach (var syllable in syllables)
            {
                strInterpretation.Append(syllable.ToString());
                strInterpretation.Append(" + ");
            }
            strInterpretation.Remove(strInterpretation.Length - 3, 3);
            return strInterpretation.ToString();
        }
        //построение полинома являющегося частной производной исходного полинома по одному из его переменных
        public void Derivative(int i)
        {
            if (i > 3 || i < 1) throw new ArgumentOutOfRangeException();
            foreach (var syllable in syllables)
            {
                syllable.GetDerivative(i);
                if (syllable.Coefficient == 0)
                    syllables.Remove(syllable);
            }
        }
        //вычисляет значение полинома в некоторой точке
        public int ValueAtPoint(int x, int y, int z)
        {
            var sum = 0;
            foreach (var syllable in syllables)
                sum += syllable.ValueAtPoint(x, y, z);
            return sum;
        }

        public void Delete(int deg1, int deg2, int deg3)
        {
            // проверка на наличие такого в пос-ности
            foreach (var syllable in syllables)
            {
                if (syllable.CheckForReplace(deg1, deg2, deg3))
                {
                    syllables.Remove(syllable);
                    break;
                }
            }
        }

        private void InsertForSum(int coef, int deg1, int deg2, int deg3)
        {
            Syllable newSyllable = new Syllable(coef, deg1, deg2, deg3);
            if (syllables.IsEmpty()) syllables.AddFirst(newSyllable);
            else
            {
                Syllable previosSyllable = null;
                var i = 0;
                foreach (var syllable in syllables)
                {
                    if (syllable.GetSumPowers() < newSyllable.GetSumPowers())
                    {
                        if (previosSyllable == null) syllables.AddFirst(newSyllable);
                        else syllables.AddByIndex(i, newSyllable);
                        break;
                    }
                    else if (syllable.GetSumPowers() >= newSyllable.GetSumPowers() && syllables.Count == i - 1)
                    {
                        syllables.AddLast(newSyllable);
                        break;
                    }
                    else
                    {
                        if (syllable.CheckForSum(newSyllable))
                        {
                            syllable.Coefficient += coef;
                            if (syllable.Coefficient == 0) { syllables.Remove(syllable); i--; }
                            break;
                        }
                        else
                        {
                            if (newSyllable.CompareTo(syllable) < 0)
                            {
                                syllables.AddByIndex(i, newSyllable);
                                break;
                            }
                        }
                    }
                    i++;
                    previosSyllable = syllable;
                }
            }
        }
        //вставка элемента в список
        public void InsertElemInList(int coef, int deg1, int deg2, int deg3)
        {
            Syllable newSyllable = new Syllable(coef, deg1, deg2, deg3);
            if (syllables.IsEmpty()) syllables.AddFirst(newSyllable);
            else
            {
                Syllable previosSyllable = null;
                var i = 0;
                foreach (var syllable in syllables)
                {
                    if (syllable.GetSumPowers() < newSyllable.GetSumPowers())
                    {
                        if (previosSyllable == null) syllables.AddFirst(newSyllable);
                        else syllables.AddByIndex(i, newSyllable);
                        break;
                    }
                    else if (syllable.GetSumPowers() >= newSyllable.GetSumPowers() && syllables.Count == i - 1)
                    {
                        syllables.AddLast(newSyllable);
                        break;
                    }
                    else
                    {
                        if (syllable.CheckForSum(newSyllable))
                        {
                            syllables.Remove(syllable);
                            syllables.AddByIndex(i, newSyllable);
                            break;

                        }
                        else
                        {
                            if (newSyllable.CompareTo(syllable) < 0)
                            {
                                syllables.AddByIndex(i, newSyllable);
                                break;
                            }
                        }
                    }
                    i++;
                    previosSyllable = syllable;
                }
            }
        }
        //сумма двух полиномов
        public void Summ(Polinom p)
        {
            foreach (var syllable in p.syllables)
            {
                this.InsertForSum(syllable.Coefficient, syllable.PowerX, syllable.PowerY, syllable.PowerZ);
            }
        }
        //не до конца поняла что нужно делать в этом методе, сделала так, что он возвращает степени многочлена, имеющего минимальный коэффицент и он не работает:(
        public string GetPowersWithMinCoef()
        {
            var builder = new StringBuilder();
            int min = int.MaxValue;
            var c = syllables.First;
            for (var i = syllables.First; i != null; i = i.Next)
            {
                if (i.Data.Coefficient < min)
                {
                    min = i.Data.Coefficient;
                    c = i;
                }
            }
            builder.Append(c.Data.PowerX);
            builder.Append(c.Data.PowerY);
            builder.Append(c.Data.PowerZ);
            return builder.ToString();
        }
    }
}


