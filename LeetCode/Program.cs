using LeetCode.Classes;
using LeetCode.Problems;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] nums = [1, 7, 16, 23, 37, 44, 59];
int value = 22;
SearchInsertPosition searchInsert = new();
Console.WriteLine(searchInsert.SearchInsert(nums, value));