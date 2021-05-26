using CodingChallenges.LeetCode.TopInterviewQuestions.MathProblems;
using Xunit;

namespace Tests
{
    public class MathTests
    {
        [Fact]
        public void IsHappy_BaseCase()
        {
            var res = new IsHappySolution().IsHappy(19);
            Assert.True(res);
        }
    }
}
