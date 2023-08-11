namespace AdaMasterClass.AugustTwoThree.Tests
{
    public static class TennisScore
    {
        private static string LoveLove = $"{Love} - {Love}";
        private static int scorePlayerServing;

        private const string Love = "love";
        private const string Fifteen = "fifteen";

        public static string GetScore()
        {
            if(scorePlayerServing == 1)
            {
                return FormatScore(Fifteen, Love);
            }
            return FormatScore(Love, Love);
        }

        private static string FormatScore(string playerServing, string playerReceiving)
        {
            return $"{playerServing} - {playerReceiving}";
        }

        public static void PlayerServingScore()
        {
            scorePlayerServing = 1;
        }
    }
}