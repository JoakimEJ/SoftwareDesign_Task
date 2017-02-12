using System;

namespace SnakeOrder
{
	class InputController
	{
		public InputController() { }

		public bool ExitGame(ConsoleKeyInfo cki)
		{
			bool exit = false;
			if (cki.Key == ConsoleKey.Escape)
				exit = true;
			return exit;
		}
		
		public bool Pause(bool pause, ConsoleKeyInfo cki)
		{
			if (cki.Key == ConsoleKey.Spacebar)
			{
				pause = !pause;
			}
			return pause;
		}

		public Direction GetNewDirection(Direction lastDirection, ConsoleKeyInfo cki)
		{
			// 0=up, 1=right, 2=down, 3=left
			Direction newDirection = lastDirection;
			if (cki.Key == ConsoleKey.UpArrow && lastDirection != Direction.DOWN)
				newDirection = Direction.UP;
			else if (cki.Key == ConsoleKey.RightArrow && lastDirection != Direction.LEFT)
				newDirection = Direction.RIGHT;
			else if (cki.Key == ConsoleKey.DownArrow && lastDirection != Direction.UP)
				newDirection = Direction.DOWN;
			else if (cki.Key == ConsoleKey.LeftArrow && lastDirection != Direction.RIGHT)
				newDirection = Direction.LEFT;
			return newDirection;
		}

	}
}
