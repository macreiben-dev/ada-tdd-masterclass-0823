using NFluent;

namespace AdaMasterClass.AugustTwoThree.Tests
{
    public class TennisScoreTest
    {
        /**
         * 
         * The checked string:
	        ["love- love"]
        */

        [Fact]
        public void Given_game_is_starting_Then_score_is_lovelove()
        {
            // ARRANGE
            var score = "love - love";

            // ACT
            var actual = TennisScore.GetScore();

            // ASSERT
            Check.That(actual).IsEqualTo(score);
        }

        [Fact]
        public void Given_firstPoint_is_played_Then_score_is_loveFifteen()
        {
            // ARRANGE
            var score = "fifteen - love";

            // ACT
            TennisScore.PlayerServingScore();
            var actual = TennisScore.GetScore();

            // ASSERT
            Check.That(actual).IsEqualTo(score);
        }
    }
}