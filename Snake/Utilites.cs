namespace Snake
{
    using System;

    public static class Utilites
    {
        private static readonly Random Randomizer = new Random();
        private static readonly ConsoleColor ExitBackgroundColor = ConsoleColor.Black;
        private static readonly ConsoleColor ExitForegroungColor = ConsoleColor.White;

        public static int GenerateNumber(int min, int max)
        {
            return Randomizer.Next(min, max + 1);
        }

        public static void ConsoleDefaultColors()
        {
            Console.BackgroundColor = ExitBackgroundColor;
            Console.ForegroundColor = ExitForegroungColor;
        }
    }
}