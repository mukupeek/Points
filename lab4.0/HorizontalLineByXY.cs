using System.Collections.Generic;

namespace lab4._0
{
    class HorizontalLinePoint : Figure
    {
        public HorizontalLinePoint(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point point = new Point(x, y, sym);
                pList.Add(point);
            }
        }
    }

}

