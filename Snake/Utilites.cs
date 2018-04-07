namespace Snake
{
    using System;

    public static class Utilites
    {
        private static readonly Random Randomizer = new Random();

        public static int GenerateNumber(int min, int max)
        {
            return Randomizer.Next(min, max + 1);
        }
    }
}