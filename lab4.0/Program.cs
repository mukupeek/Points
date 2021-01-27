using System;

namespace lab4._0
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Walls w = new Walls(Console.WindowWidth, Console.WindowHeight);
            w.Draw();
            Console.ReadKey();
        }
    }
}
