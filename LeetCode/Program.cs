using LeetCode.Classes;
using LeetCode.Problems;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] nums = [3, 2, 2, 3];
int value = 3;
RemoveElementProblem removeElementProblem = new();
var result = removeElementProblem.RemoveElement(nums, value);
Console.WriteLine(result);

