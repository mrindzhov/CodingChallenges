using CodingChallenges.LeetCode.TopInterviewQuestions.DynamicProgramming;
using Xunit;

namespace Tests
{
    public class DynamicProgrammingTests
    {
        [Fact]
        public void UniquePaths_BaseCase()
        {
            var res = new UniquePathsSolution().UniquePaths(3, 7);
            Assert.Equal(28, res);
        }

        [Fact]
        public void CanJump_BaseCase()
        {
            var canJump = new CanJumpSolution().CanJump(new int[] { 2, 3, 1, 1, 4 });
            Assert.True(canJump);
        }

        [Fact]
        public void CanJump_BaseCase_2()
        {
            var canJump = new CanJumpSolution().CanJump(new int[] { 3, 2, 1, 0, 4 });
            Assert.False(canJump);
        }

        [Fact]
        public void CoinChange_BaseCase()
        {
            var res = new CoinChangeSolution().CoinChange(new int[] { 1, 2, 5 }, 11);
            Assert.Equal(3, res);
        }

        [Fact]
        public void CoinChange_BaseCase_2()
        {
            var res = new CoinChangeSolution().CoinChange(new int[] { 2 }, 3);
            Assert.Equal(-1, res);
        }

        [Fact]
        public void CoinChange_BaseCase_3()
        {
            var res = new CoinChangeSolution().CoinChange(new int[] { 1, 3, 4, 5 }, 7);
            Assert.Equal(2, res);
        }
    }
}
