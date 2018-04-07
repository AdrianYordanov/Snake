namespace Snake.Models.Parts
{
    using System;

    public class FoodPart : Part
    {
        private const char FoodCharacter = '*';
        private const ConsoleColor DefaultColor = ConsoleColor.Green;
        private const ConsoleColor BackgrounColor = ConsoleColor.Black;
        private readonly int leftBorder;
        private readonly int rightBorder;
        private readonly int upBorder;
        private readonly int downBorder;

        public FoodPart(int leftBorder, int rightBorder, int upBorder, int downBorder)
            : this(leftBorder, rightBorder, upBorder, downBorder, DefaultColor)
        {
        }

        public FoodPart(int leftBorder, int rightBorder, int upBorder, int downBorder, ConsoleColor color)
            : base(0, 0, color)
        {
            this.leftBorder = leftBorder;
            this.rightBorder = rightBorder;
            this.upBorder = upBorder;
            this.downBorder = downBorder;
        }

        public override void Paint()
        {
            this.X = Utilites.GenerateNumber(this.leftBorder + 1, this.rightBorder - 1);
            this.Y = Utilites.GenerateNumber(this.upBorder + 1, this.downBorder - 1);
            Console.SetCursorPosition(this.X, this.Y);
            Console.BackgroundColor = BackgrounColor;
            Console.ForegroundColor = DefaultColor;
            Console.Write(FoodCharacter);
        }
    }
}