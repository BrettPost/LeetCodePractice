using LeetCode.Classes;

namespace LeetCode.Problems
{
    internal class ReversedLinkedList
    {

        public ListNode reverseList(ListNode headNode)
        {
            ListNode current = headNode;
            ListNode prev = null;
            ListNode next;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            headNode = prev;

            return headNode;
        }
    }
}