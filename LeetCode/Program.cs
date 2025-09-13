using LeetCode.Classes;
using LeetCode.Problems;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ListNode third = new ListNode(3);
ListNode second = new ListNode(2, third);
ListNode first = new ListNode(1, second);

ReversedLinkedList reversedLinkedList = new();
ListNode result = reversedLinkedList.reverseList(first);

while (result.next != null)
{
    Console.Write(result.val);
    result = result.next;
}

Console.Write(result.val + "\n\n");