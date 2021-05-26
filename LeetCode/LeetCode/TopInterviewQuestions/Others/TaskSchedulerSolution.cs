using System.Collections.Generic;

namespace CodingChallenges.LeetCode.TopInterviewQuestions.Others
{
    public class TaskSchedulerSolution
    {
        public int LeastInterval(char[] tasks, int n)
        {
            if (n == 0) return tasks.Length;
            var hashset = new HashSet<int>(n);
            /* queue is good */
            var queue = new Queue<char>(tasks);

            while (queue.Count > 0)
            {
                var task = queue.Dequeue();
                if (true)
                {

                }
            }
            /*
             * {
             *  A => 3,
             *  B => 3
             * }
             * 
             * 
             * A, A, A, B, B, B
             * 
             * if(Object.values any has NO_IDX || dict.get tasks[i] < n)
             * {
             *      if dict.get tasks[i] 
             *      tasks[i] => i
             * }



             
             */


            return 0;
        }
    }
}
