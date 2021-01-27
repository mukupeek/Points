using System;

namespace lab4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //ТЕСТ
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

           //Рисуем квадрат
            HorizontalLine h4 = new HorizontalLine(1, 8, 16, '*');
            h4.Draw();
            HorizontalLine h6 = new HorizontalLine(1, 8, 20, '*');
            h6.Draw();
            VerticalLine v4 = new VerticalLine(17, 19, 1, '*');
            v4.Draw();
            VerticalLine v5 = new VerticalLine(17, 19, 8, '*');
            v5.Draw();
            

            
            HorizontalLine h7 = new HorizontalLine(1, 20, 22, '/');
            h7.Draw();

            //Проверка совпадения точек (в кдварате)
            Point p1 = new Point(4, 18, '*');
            Point p2 = new Point(p1);
            p1.Draw();
            p2.Draw();
            bool t1 = p1.IsHit(p2);
            Console.SetCursorPosition(11, 18);
            if (t1) Console.WriteLine("Точки совпадают"); else Console.WriteLine("Точки не совпадают");
           
            Point p3 = new Point(5,19,'*');
            p3.Draw();          
            bool t2 = p1.IsHit(p3);
            Console.SetCursorPosition(11, 19);
            if (t2) Console.WriteLine("Точки совпадают"); else Console.WriteLine("Точки не совпадают");


            // Проверка пересечения линий
            VerticalLine v6 = new VerticalLine(25, 35, 8, '*');
            v6.Draw();
            HorizontalLine h10 = new HorizontalLine(1, 20, 30, '*');
            h10.Draw();
            bool v = v6.IsHit(h10);
            if (v) Console.WriteLine("Линии пересекаются"); else Console.WriteLine("Линии не пересекаются");

            VerticalLine v7 = new VerticalLine(38, 42, 8, '*');
            v7.Draw();
            HorizontalLine h11 = new HorizontalLine(1, 20, 37, '*');
            h11.Draw();
            bool v01 = v7.IsHit(h11);
            if (v01) Console.WriteLine("Линии пересекаются"); else Console.WriteLine("Линии не пересекаются");
            Console.ReadKey();
        }
    }
}
