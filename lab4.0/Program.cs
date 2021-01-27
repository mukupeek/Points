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

			Point food = new Point(4, 2, '$');
			food.Draw();
			while (true)
			{
				if (!w.IsHit(snake) && !snake.IsHit(food))
				{										
						if (snake.Eat(food))
						{
							food = new Point(food.x + 2, food.y + 1, '$');
							food.Draw();
						}
						else
						{
							snake.Move();
						}
						Thread.Sleep(100);
						if (Console.KeyAvailable)
						{
							ConsoleKeyInfo key = Console.ReadKey();
							snake.HandleKey(key.Key);
						}
					}
					else
					{
						Console.SetCursorPosition(60, 15);
						Console.WriteLine("Game over");
						Console.ReadKey();

					}				
			}

		}
    }
}
