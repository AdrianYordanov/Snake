namespace Snake.Models.Parts
{
    using System;
    using Interfaces;

    public abstract class Part : IPosition, IPaintable
    {
        protected Part()
        {
        }

        protected Part(int x, int y, ConsoleColor color)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
        }

        public ConsoleColor Color
        {
            get;
        }

        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        public abstract void Paint();
    }
}