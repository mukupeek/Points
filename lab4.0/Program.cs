using System;

namespace lab4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine h1 = new HorizontalLine(1, 3, 3, '*');
            h1.Draw();
            HorizontalLine h2 = new HorizontalLine(1, 5, 4, '*');
            h2.Draw();
            HorizontalLine h3 = new HorizontalLine(1, 7, 5, '*');
            h3.Draw();
            VerticalLine v1 = new VerticalLine(1, 3, 10, '*');
            v1.Draw();
            VerticalLine v2 = new VerticalLine(1, 5, 11, '*');
            v2.Draw();
            VerticalLine v3 = new VerticalLine(1, 7, 12, '*');
            v3.Draw();

            HorizontalLine h5 = new HorizontalLine(1, 20, 14, '/');
            h5.Draw();
            Console.WriteLine();
            HorizontalLine h4 = new HorizontalLine(1, 8, 16, '*');
            h4.Draw();
            HorizontalLine h6 = new HorizontalLine(1, 8, 20, '*');
            h6.Draw();
            VerticalLine v4 = new VerticalLine(17, 19, 1, '*');
            v4.Draw();
            VerticalLine v5 = new VerticalLine(17, 19, 8, '*');
            v5.Draw();
            Console.ReadKey();
        }
    }
}
