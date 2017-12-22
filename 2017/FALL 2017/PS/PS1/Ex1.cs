using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleGame
{
    class Program
    {
        public class At
        {
            private readonly int _xLimit;
            private readonly int _yLimit;
            public At()
                : this(Console.WindowWidth / 2, 0, Console.WindowWidth - 1, Console.WindowHeight - 2)
            { }

            public At(int x, int y, int xLimit, int yLimit)
            {
                X = x;
                Y = y;
                _xLimit = xLimit;
                _yLimit = yLimit;
                // Производим первичную отрисовку
                Console.SetCursorPosition(X, Y);
                Console.Write('@');
            }
            public int X { get; private set; }
            public int Y { get; private set; }

            public void Move(ConsoleKey direction)
            {
                // Стираем следы (все пиксели игрового объекта на поле)
                Console.SetCursorPosition(X, Y);
                Console.Write(' ');
                switch (direction)
                {
                    case ConsoleKey.LeftArrow:
                        if (X > 0) X--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (X < _xLimit) X++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (Y > 0) Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (Y < _yLimit)
                            Y++;
                        break;
                }
                // Отрисовываем объект в новой позиции
                Console.SetCursorPosition(X, Y);
                Console.Write('@');
            }
        }
        static void Main()
        {
            // Инициализация параметров
            Console.BufferWidth = Console.WindowWidth = 32;
            Console.BufferHeight = Console.WindowHeight = 22;
            // Прячем курсор для красоты
            Console.CursorVisible = false;
            // Установка параметра задержки смены кадров
            const int frameDelay = 100;
            var stopwatch = new Stopwatch();

            // Создаём игровые объекты
            var at = new At();

            bool gameOver = false;
            //Игровой цикл
            while (!gameOver)
            {
                stopwatch.Start();
                // В нём нужно выполнять действия по нажатию кнопок
                // Обновлять положения объектов
                // Определять столкновения и всё такое

                // Обработка нажатий клавиатуры
                if (Console.KeyAvailable)
                {
                    var keyPressed = Console.ReadKey(true).Key;
                    while (Console.KeyAvailable)
                        Console.ReadKey(true);
                    if (keyPressed == ConsoleKey.Escape) break;

                    // Перемещение объектов по нажатию кнопок
                    at.Move(keyPressed);
                }

                // Вычисление задержки для поддержания стабильного FPS
                stopwatch.Stop();
                int sleepTime = Math.Max(frameDelay - (int)stopwatch.Elapsed.TotalMilliseconds, 0);
                // Задержка
                Thread.Sleep(sleepTime);
            }
            Console.Clear();
        }
    }
}
