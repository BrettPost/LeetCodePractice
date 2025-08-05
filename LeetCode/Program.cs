using LeetCode.Classes;
using LeetCode.Problems;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


MergeTwoSortedLists mergeTwoSortedLists = new();
var exampleLists = mergeTwoSortedLists.GiveTwoNodeLists();
var result = mergeTwoSortedLists.MergeTwoLists(exampleLists.Item1, exampleLists.Item2);
Console.WriteLine(result);


