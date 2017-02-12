using System;

namespace SnakeOrder
{
	class GameBoard
	{
		private int _boardWidth;
		private int _boardHeight;

		public int BoardWidth { get { return _boardWidth; } }
		public int BoardHeight { get { return _boardHeight; } }
		public GameBoard(int width, int height, string title)
		{
			this._boardWidth = width;
			this._boardHeight = height;
			Console.CursorVisible = false;
			Console.Title = title;
		}
	}
}
