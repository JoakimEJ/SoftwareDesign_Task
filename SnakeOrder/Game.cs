using System;
using System.Threading;

namespace SnakeOrder
{
	class Game
	{
		private Snake _snake;
		private Point _foodPoint;
		private GameBoard _window;
		private InputController _inputController;
		private Random _random;
		private bool _gameOver, _pause, _eatingFood;
		private Direction _newDirection;
		private Direction _lastDirection;
		private ConsoleKeyInfo _cki;

		public Game(GameBoard window, Snake snake, InputController inputController)
		{
			this._window = window;
			this._snake = snake;
			this._inputController = inputController;
		}

		public void Start()
		{
			InitializeComponent();
			GameLoop();
		}

		private void InitializeComponent()
		{
			_foodPoint = new Point();
			_random = new Random();
			_gameOver = false;
			_pause = false;
			_eatingFood = false;
			_newDirection = Direction.DOWN;
			_lastDirection = _newDirection;
			CreateAndPlaceFood();
		}
		// Main game loop
		private void GameLoop()
		{

			while (!_gameOver)
			{
				// 10 fps -> next iteration in while
				Thread.Sleep(100);
				CheckConsoleInput();
				if (!_pause)
				{
					_snake.MoveTo(_newDirection);
					CheckCollisions();

					if (!_gameOver)
					{
						_snake.DrawTail();
						if (!_eatingFood)
						{
							_snake.GetSnake().RemoveAt(0);
							_snake.DrawEmptyPlace();
						}
						else
						{
							_eatingFood = false;
						}
						_snake.GetSnake().Add(_snake.NewHead);
						_snake.DrawHead();
						_lastDirection = _newDirection;
						_snake.UpdatePosition();
					}
				}
			}
		}

		/* Utilities / Rules for gameboard follows below */
		private void CreateAndPlaceFood()
		{
			bool found = false;
			while (!found)
			{
				ChooseFoodPositionRandomly();
				found = IsSpotAvailable();
				if (found)
				{
					
					_foodPoint.Draw();
				}
			}

		}

		private void ChooseFoodPositionRandomly()
		{
			_foodPoint.X = _random.Next(0, _window.BoardWidth);
			_foodPoint.Y = _random.Next(0, _window.BoardHeight);
		}

		private bool IsSpotAvailable()
		{
			bool isSpotAvailable = true;
			foreach (Point snakepoint in _snake.GetSnake())
				if (snakepoint.X == _foodPoint.X && snakepoint.Y == _foodPoint.Y)
				{
					isSpotAvailable = false;
				}
			return isSpotAvailable;
		}
	
		private void CheckConsoleInput()
		{
			if (Console.KeyAvailable)
			{
				_cki = Console.ReadKey(true);
				_gameOver = _inputController.ExitGame(_cki);
				_pause = _inputController.Pause(_pause, _cki);
				_newDirection = _inputController.GetNewDirection(_lastDirection, _cki);
			}
		}

		private bool SnakeEatFood()
		{
			return (_snake.NewHead.X == _foodPoint.X && _snake.NewHead.Y == _foodPoint.Y);
		}

		private void CheckCollisions()
		{
			CheckWallCollision();
			CheckSelfCollision();
			CheckFoodCollision();
		}

		private void CheckWallCollision()
		{
			if (_snake.NewHead.X < 0 || _snake.NewHead.X >= _window.BoardWidth)
				_gameOver = true;
			// If head of snake passes height-range of board: gameOver
			else if (_snake.NewHead.Y < 0 || _snake.NewHead.Y >= _window.BoardHeight)
				_gameOver = true;
		}

		private void CheckSelfCollision()
		{
			foreach (Point snakePoint in _snake.GetSnake())
			{
				if (snakePoint.X == _snake.NewHead.X && snakePoint.Y == _snake.NewHead.Y)
				{
					// Death by accidental self-cannibalism.
					_gameOver = true;
					break;
				}
			}
		}
		private void CheckFoodCollision()
		{
			if (SnakeEatFood())
			{
				if (Won())
					_gameOver = true;
				else {
					CreateAndPlaceFood();
					_eatingFood = true;
				}
			}
		}

		// No more room to place food - game over.
		private bool Won()
		{
			return (_snake.GetSnake().Count + 1 >= _window.BoardWidth * _window.BoardHeight);
		}
	}
}