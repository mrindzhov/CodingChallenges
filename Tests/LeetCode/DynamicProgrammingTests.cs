using CodingChallenges.LeetCode.TopInterviewQuestions.DynamicProgramming;
using Xunit;

namespace Tests.LeetCode
{
    public class DynamicProgrammingTests
    {
        [Theory]
        [InlineData(3, 7, 28)]
        public void UniquePaths_BaseCase(int m, int n, int result)
        {
            var res = new UniquePathsSolution().UniquePaths(m, n);
            Assert.Equal(result, res);
        }

        [Theory]
        [InlineData(new int[] { 2, 3, 1, 1, 4 }, true)]
        [InlineData(new int[] { 3, 2, 1, 0, 4 }, false)]
        public void CanJump(int[] nums, bool canJump)
        {
            Assert.Equal(canJump, new CanJumpSolution().CanJump(nums));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 5 }, 11, 3)]
        [InlineData(new int[] { 2 }, 3, -1)]
        [InlineData(new int[] { 1, 3, 4, 5 }, 7, 2)]
        public void CoinChange(int[] coins, int amount, int expectedResult)
        {
            var res = new CoinChangeSolution().CoinChange(coins, amount);
            Assert.Equal(expectedResult, res);
        }
    }
}
