using LeetCode.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    //ListNode third = new ListNode(3);
    //ListNode second = new ListNode(2, third);
    //ListNode dup = new ListNode(2, second);
    //ListNode head = new ListNode(1, dup);


    //RemoveDupFromSortLinkedList removeDupFromSortLinkedList = new();
    //var result = removeDupFromSortLinkedList.DeleteDuplicates(head);

    //while (result.next != null)
    //{
    //    Console.Write(result.val);
    //    result = result.next;
    //}

    //Console.Write(result.val + "\n\n");


internal class RemoveDupFromSortLinkedList
    {

        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null) { return head; }
            if (head.next.val == head.val) { return DeleteDuplicates(head.next); }

            head.next = DeleteDuplicates(head.next);

            return head;
        }
    }
}
