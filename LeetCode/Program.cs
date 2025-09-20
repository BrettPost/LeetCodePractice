using LeetCode.Classes;
using LeetCode.Problems;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

AddBinaryProblem addBinaryProblem = new();
var result = addBinaryProblem.AddBinary("11", "101011"); // 233 + 170 = 403 -> 110010011
Console.WriteLine(result);
