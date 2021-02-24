using System.Numerics;
using System.Text;

namespace CodingChallenges.LeetCode
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int val=0, ListNode next=null) {
     *         this.val = val;
     *         this.next = next;
     *     }
     * }
     */
    public static class Solution
    {
        static void Execute()
        {
            var l11 = new ListNode(1,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(0,
             new ListNode(1)
                ))))))))))))))))))))))))))))));

            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            var res = AddTwoNumbers(l11, l2);
            var curr = res;
            while (curr != null)
            {
                System.Console.WriteLine(curr.val);
                curr = curr.next;
            }
        }
        private static readonly StringBuilder sb = new StringBuilder();
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var num1 = GetNumber(l1);
            var num2 = GetNumber(l2);
            var result = num1 + num2;

            var newHead = new ListNode(0);
            var resultNode = newHead;
            while (result >= 1)
            {
                int lastDiggit = (int)(result % 10);
                result /= 10;
                resultNode.next = new ListNode(lastDiggit);
                resultNode = resultNode.next;
            }

            return num1 + num2 == 0 ? newHead : newHead.next;
        }

        private static BigInteger GetNumber(ListNode listNode)
        {
            sb.Clear();
            do
            {
                sb.Insert(0, listNode.val);
                listNode = listNode.next;
            } while (listNode != null);


            return BigInteger.Parse(sb.ToString());
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
