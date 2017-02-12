using System;

namespace SnakeOrder
{
	class Application
	{
		public static void Main(string[] arguments)
		{
			GameBoard window = new GameBoard(Console.WindowWidth, Console.WindowHeight, "Westerdals Oslo ACT - SNAKE");
			Snake snake = new Snake(4);
			InputController inputController = new InputController();
			Game game = new Game(window, snake, inputController);


			game.Start();
		
		}
	}
}
