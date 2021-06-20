using CodingChallenges.LeetCode.TopInterviewQuestions.Others;
using Xunit;

namespace Tests.LeetCode
{
    public class OthersTests
    {
        [Theory]
        /*
         A -> B -> idle -> A -> B -> idle -> A -> B
         There is at least 2 units of time between any two same tasks.
         */
        [InlineData(new char[] { 'A', 'A', 'A', 'B', 'B', 'B', }, 2, 8)]
        [InlineData(new char[] { 'A', 'A', 'A', 'B', 'B', 'B', }, 0, 6)]
        // A->B->C->A->D->E->A->F->G->A->idle->idle->A->idle->idle->A
        [InlineData(new char[] { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'C', 'D', 'E', 'F', 'G' }, 2, 16)]
        public void LeastInterval(char[] tasks, int n, int result)
        {
            var res = new TaskSchedulerSolution().LeastInterval(tasks, n);
            Assert.Equal(result, res);
        }
    }
}
