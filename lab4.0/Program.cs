using System;
using System.Threading;

namespace lab4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Walls w = new Walls(Console.WindowWidth, Console.WindowHeight);
            w.Draw();
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                snake.Move();
                Thread.Sleep(100);
            }

        }
    }
}
