using LeetCode.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class MergeTwoSortedLists
    {
        // length between 0 and 50
        // value of node between -100 and and 100 inclusive
        // sorted increasingly

        private int[] list1 = [1, 1, 4, 10];
        private int[] list2 = [2, 3, 4];

        public (ListNode, ListNode) GiveTwoNodeLists()
        {
            List<ListNode> preList1 = new();
            List<ListNode> preList2 = new();

            for (int i = list1.Length - 1; i >= 0; i--)
            {
                preList1.Add(new ListNode(list1[i], preList1.LastOrDefault()));
            }

            for (int i = list2.Length - 1; i >= 0; i--)
            {
                preList2.Add(new ListNode(list2[i], preList2.LastOrDefault()));
            }

            return (preList1.Last(), preList2.Last());
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }

            if (list1.val <= list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }
        
        // MergeTwoSortedLists mergeTwoSortedLists = new();
        // var exampleLists = mergeTwoSortedLists.GiveTwoNodeLists();
        // var result = mergeTwoSortedLists.MergeTwoLists(exampleLists.Item1, exampleLists.Item2);
        // Console.WriteLine(result);
    }
}
