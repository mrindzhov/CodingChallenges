using CodingChallenges.LeetCode.TopInterviewQuestions.Arrays;
using Xunit;

namespace Tests
{
    public class ArraysAndStringsTests
    {
        [Fact]
        public void FindMissingRanges_BaseCase()
        {
            var res = new MissingRanges().FindMissingRanges(new int[] { 0, 1, 3, 50, 75 }, 0, 99);

            Assert.Equal(new string[] { "2", "4->49", "51->74", "76->99" }, res);
        }
    }
}
