using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeOrder
{
	class Snake
	{
		private List<Point> _snake;

		private Point _tail;
		private Point _head;
		private Point _newHead;

		public Point Tail { get { return _tail; } set { this._tail = value; } }
		public Point Head { get { return _head; } set { this._head = value; } }
		public Point NewHead { get { return _newHead; } set { this._newHead = value; } }

		public Snake(){}

		public Snake(int bodyParts)
		{
			_snake = new List<Point>();
			for (int i = 0; i < bodyParts; i++)
			{
				_snake.Add(new Point(10, 10));
			}
			UpdatePosition();
		}

		public void UpdatePosition()
		{
			_tail = new Point(_snake.First());
			_head = new Point(_snake.Last());
			_newHead = new Point(_head);
		}
		public void DrawTail()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(this._head.X, this._head.Y);
			Console.Write("0");
		}
		public void DrawHead()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(this._newHead.X, this._newHead.Y);
			Console.Write("@");
		}
		public void DrawEmptyPlace()
		{
			Console.SetCursorPosition(this.Tail.X, this.Tail.Y);
			Console.Write(" ");
		}

		public List<Point> GetSnake()
		{
			return _snake;
		}
		public void MoveTo(Direction newDirection)
		{
			switch (newDirection)
			{
				// 0 = up, 1 = right, 2 = down, 3 = left
				case Direction.UP:
					this._newHead.Y--;
					break;
				case Direction.RIGHT:
					this._newHead.X++;
					break;
				case Direction.DOWN:
					this._newHead.Y++;
					break;
				default:
					this._newHead.X--;
					break;
			}
		}
	}
}


