using NFluent;

namespace AdaMasterClass.AugustTwoThree.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_starting_at_zero()
        {
            // ARRANGE
            var score = "love - love";

            // ACT
            var actual = TennisScore.GetScore();

            // ASSERT
            Check.That(actual).IsEqualTo(score);
        }
    }
}