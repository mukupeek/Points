using System;

namespace lab4._0
{
    class Point
    {
        int x, y;
        char sym;

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public void Draw()
        {
           Console.SetCursorPosition(x, y);
           Console.Write('*');
        }
    }
}
