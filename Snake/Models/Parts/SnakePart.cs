namespace Snake.Models.Parts
{
    using System;

    public class SnakePart : Part
    {
        private const char SnakeCharacter = ' ';
        private const ConsoleColor DefaultColor = ConsoleColor.DarkCyan;

        public SnakePart(int x, int y)
            : this(x, y, DefaultColor)
        {
        }

        public SnakePart(int x, int y, ConsoleColor color)
            : base(x, y, color)
        {
        }

        public override void Paint()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.BackgroundColor = this.Color;
            Console.Write(SnakeCharacter);
        }
    }
}