using LeetCode.MathProblems;
using Xunit;

namespace LeetCode.Tests
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
