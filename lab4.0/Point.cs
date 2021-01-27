using System;

namespace lab4._0
{
    class Point
    {
        public int x, y;
        public char sym;

        public Point(int x, int y, char sym)
        {
            if (x >= 0)
            {
                this.x = x;
            }
            else throw new Exception("Значение не может быть отрицательным");
            if (y >= 0)
            {
                this.y = y;
            }
            else throw new Exception("Значение не может быть отрицательным");
            this.sym = sym;

        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Draw()
        {
           Console.SetCursorPosition(x, y);
           Console.Write(sym);
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

    }

}
