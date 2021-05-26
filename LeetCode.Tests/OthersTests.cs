using CodingChallenges.LeetCode.TopInterviewQuestions.Others;
using Xunit;

namespace Tests
{
    public class OthersTests
    {
        [Fact]
        public void LeastInterval_BaseCase()
        {
            var tasks = new char[] { 'A', 'A', 'A', 'B', 'B', 'B', };
            var res = new TaskSchedulerSolution().LeastInterval(tasks, 2);
            /*
             A -> B -> idle -> A -> B -> idle -> A -> B
             There is at least 2 units of time between any two same tasks.
             */

            Assert.Equal(8, res);
        }

        [Fact]
        public void LeastInterval_BaseCase_2()
        {
            var tasks = new char[] { 'A', 'A', 'A', 'B', 'B', 'B', };
            var res = new TaskSchedulerSolution().LeastInterval(tasks, 0);

            Assert.Equal(6, res);
        }

        [Fact]
        public void LeastInterval_BaseCase_3()
        {
            var tasks = new char[] { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            var res = new TaskSchedulerSolution().LeastInterval(tasks, 2);
            // A->B->C->A->D->E->A->F->G->A->idle->idle->A->idle->idle->A

            Assert.Equal(16, res);
        }
    }
}
