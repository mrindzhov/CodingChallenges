using LeetCode.SortingAndSearching;
using Xunit;

namespace LeetCode.Tests
{
    public class SearchingAndSortingTests
    {
        [Fact]
        public void SearchTest_BaseCase()
        {
            var res = new SearchSolution().Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
            Assert.Equal(4, res);
        }

        [Fact]
        public void SearchTest_EdgeCase()
        {
            var res = new SearchSolution().Search(new int[] { 5, 1, 3 }, 5);
            Assert.Equal(0, res);
        }
    }
}
