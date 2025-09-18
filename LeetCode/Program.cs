using LeetCode.Classes;
using LeetCode.Problems;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

PlusOneProblem plusOneProblem = new();
var result = plusOneProblem.PlusOne([]);

foreach (var problem in result)
{
    Console.WriteLine(problem);
}