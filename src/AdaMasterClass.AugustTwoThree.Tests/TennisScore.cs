﻿namespace AdaMasterClass.AugustTwoThree.Tests
{
    internal static class TennisScore
    {
        private static string LoveLove = $"{Love} - {Love}";
        private static int scorePlayerServing;

        private const string Love = "love";

        public static string GetScore()
        {
            if(scorePlayerServing == 1)
            {
                return $"fifteen - {Love}";
            }
            return LoveLove;
        }

        internal static void PlayerServingScore()
        {
            scorePlayerServing = 1;
        }
    }
}