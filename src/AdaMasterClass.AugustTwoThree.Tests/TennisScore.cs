namespace AdaMasterClass.AugustTwoThree.Tests
{
    internal static class TennisScore
    {
        private const string LoveLove = "love - love";
        private static int scorePlayerServing;

        public static string GetScore()
        {
            if(scorePlayerServing == 1)
            {
                return "fifteen - love";
            }
            return LoveLove;
        }

        internal static void PlayerServingScore()
        {
            scorePlayerServing = 1;
        }
    }
}