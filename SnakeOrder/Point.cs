using System;

namespace SnakeOrder
{
		class Point {

		private int _x;
		private int _y;

		public int X { get { return _x; } set { this._x = value; } }
		public int Y { get { return _y; } set { this._y = value; } }

		public Point(int x = 0, int y = 0)
		{
			X = x; Y = y;
		}
		public Point(Point input)
		{
			X = input.X;  Y = input.Y;
		}

		// Draws a '$' at a given point.
		public void Draw()
		{

			Console.ForegroundColor = ConsoleColor.Green;
			Console.SetCursorPosition(this.X, this.Y);
			Console.Write("$");
		}
	}
}


