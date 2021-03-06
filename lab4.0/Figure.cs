﻿using System.Collections.Generic;

namespace lab4._0
{
	class Figure
	{
		protected List<Point> pList;

		public void Draw()
		{
			foreach (Point p in pList)
			{
				p.Draw();
			}
		}
		public bool IsHit(Figure figure)
		{
			foreach (var p in pList)
			{
				if (figure.IsHit(p))
					return true;
			}
			return false;
		}

		private bool IsHit(Point point)
		{
			foreach (var p in pList)
			{
				if (p.IsHit(point))
                {
					return true;
				}
					
			}
			return false;

		}
	}
}
