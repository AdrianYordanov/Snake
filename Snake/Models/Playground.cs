namespace Snake.Models
{
    using System;
    using Interfaces;

    public class Playground : IPaintable
    {
        private const string Title = "Developer: Adrian Yordanov";
        private const char BorderCharacter = ' ';
        private const ConsoleColor TitleColor = ConsoleColor.Cyan;
        private const ConsoleColor BorderColor = ConsoleColor.DarkMagenta;
        private readonly int leftBorder;
        private readonly int rightBorder;
        private readonly int upBorder;
        private readonly int downBoder;

        public Playground(int leftBorder, int rightBorder, int upBorder, int downBoder)
        {
            this.leftBorder = leftBorder;
            this.rightBorder = rightBorder;
            this.upBorder = upBorder;
            this.downBoder = downBoder;
        }

        public void Paint()
        {
            Console.ForegroundColor = TitleColor;
            Console.SetCursorPosition(this.leftBorder, this.upBorder - 1);
            Console.Write(Title);
            Console.BackgroundColor = BorderColor;
            for (var i = this.leftBorder; i <= this.rightBorder; i++)
            {
                Console.SetCursorPosition(i, this.upBorder);
                Console.Write(BorderCharacter);
                Console.SetCursorPosition(i, this.downBoder);
                Console.Write(BorderCharacter);
            }

            for (var i = this.upBorder; i <= this.downBoder; i++)
            {
                Console.SetCursorPosition(this.leftBorder, i);
                Console.Write(BorderCharacter);
                Console.SetCursorPosition(this.rightBorder, i);
                Console.Write(BorderCharacter);
            }
        }
    }
}