namespace Snake.Models.Parts
{
    using System;
    using Interfaces;

    public abstract class Part : IPosition, IPaintable
    {
        private int x;
        private int y;
        private ConsoleColor color;

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
            get => this.color;
            private set => this.color = value;
        }

        public int X
        {
            get => this.x;
            set => this.x = value;
        }

        public int Y
        {
            get => this.y;
            set => this.y = value;
        }

        public abstract void Paint();
    }
}