namespace Snake.Core
{
    using System;
    using System.Threading;
    using Enumerations;
    using Models;
    using Models.Parts;

    public class Engine
    {
        private const int PlaygroundBorderUp = 2;
        private const int PlaygroundBorderDown = 25;
        private const int PlaygroundBorderLeft = 5;
        private const int PlaygroundBorderRight = 60;
        private readonly Playground playground;
        private readonly Snake snake;
        private readonly FoodPart food;
        private bool isGameOver;

        public Engine()
        {
            this.playground = new Playground(PlaygroundBorderLeft,
                PlaygroundBorderRight,
                PlaygroundBorderUp,
                PlaygroundBorderDown);
            this.snake = new Snake(PlaygroundBorderLeft,
                PlaygroundBorderRight,
                PlaygroundBorderUp,
                PlaygroundBorderDown);
            this.food = new FoodPart(PlaygroundBorderLeft,
                PlaygroundBorderRight,
                PlaygroundBorderUp,
                PlaygroundBorderDown);
            this.isGameOver = false;
        }

        public void Run()
        {
            this.playground.Paint();
            this.food.Paint();
            while (!this.isGameOver)
            {
                this.CheckKey();
                this.snake.Move();
                if (this.snake.CheckEatFood(this.food))
                {
                    this.food.Paint();
                }
                else
                {
                    this.snake.CheckBiteItself(ref this.isGameOver);
                }

                Thread.Sleep(this.snake.Interval);
            }

            this.Exit();
        }

        private void CheckKey()
        {
            while (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if ((this.snake.Direction == Direction.Left) || (this.snake.Direction == Direction.Right))
                        {
                            this.snake.Direction = Direction.Up;
                        }

                        return;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if ((this.snake.Direction == Direction.Left) || (this.snake.Direction == Direction.Right))
                        {
                            this.snake.Direction = Direction.Down;
                        }

                        return;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if ((this.snake.Direction == Direction.Up) || (this.snake.Direction == Direction.Down))
                        {
                            this.snake.Direction = Direction.Left;
                        }

                        return;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if ((this.snake.Direction == Direction.Up) || (this.snake.Direction == Direction.Down))
                        {
                            this.snake.Direction = Direction.Right;
                        }

                        return;
                }
            }
        }

        private void Exit()
        {
            Utilites.ConsoleDefaultColors();
            Console.SetCursorPosition(PlaygroundBorderLeft, PlaygroundBorderDown + 2);
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey(true);
        }
    }
}