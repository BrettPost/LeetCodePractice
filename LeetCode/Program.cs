using LeetCode.Objects;
using LeetCode.Problems;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


OptimizingBoxWeights boxWeights = new();

List<int> list = boxWeights.minimalHeaviestSetA(new List<int> { 3, 7, 8, 6, 5 });


foreach (int i in list)
{
    Console.WriteLine(i);
}


