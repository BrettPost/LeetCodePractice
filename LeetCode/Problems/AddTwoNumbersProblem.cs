using LeetCode.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class AddTwoNumbersProblem
    {
        ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
        {
            if (l1 == null && l2 == null && carry == 0) return null; //Base case is if l1 == null and not if l1.next == null

            int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
            carry = total / 10;
            return new ListNode(total % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
        }

        //ListNode third = new ListNode(3);
        //ListNode second = new ListNode(4, third);
        //ListNode first = new ListNode(2, second);

        //ListNode num2third = new ListNode(4);
        //ListNode num2second = new ListNode(6, num2third);
        //ListNode num2first = new ListNode(5, num2second);

        //ListNode result = AddTwoNumbers(first, num2first);

        //while (result.next != null)
        //{
        //    Console.Write(result.val);
        //    result = result.next;
        //}

        //Console.Write(result.val + "\n\n");
    }
}
