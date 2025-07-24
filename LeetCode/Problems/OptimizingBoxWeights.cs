using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class OptimizingBoxWeights
    {
        public List<int> minimalHeaviestSetA(List<int> arr)
        {
            if (arr.Count == 0 || arr == null)
            {
                return [];
            }
            int sum = arr.Sum();
            
            List<List<int>> validSubsets = new();
            int positions = Int16.MaxValue; //find minimal faster

            for (int i = 0; i < arr.Count; i++)
            {
                List<int> subA = new();
                subA.Add(arr[i]);

                if (subA.Sum() >= sum / 2)
                {
                    if (subA.Count > positions)
                    {
                        break;
                    }

                    positions = subA.Count;
                    validSubsets.Add(subA);
                }

                for (int j = 0; j < arr.Count; j++)
                {
                    if (j == i || j == i - 1) { continue; }

                    subA.Add(arr[j]);

                    if (subA.Sum() >= sum / 2)
                    {
                        if (subA.Count > positions)
                        {
                            break;
                        }

                        positions = subA.Count;
                        validSubsets.Add(subA);
                    }
                }
            }

            return validSubsets.First().ToList(); // .Order();
        }
    }
}
