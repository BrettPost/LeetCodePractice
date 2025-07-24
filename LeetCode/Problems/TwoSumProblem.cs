using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class TwoSumProblem
    {
        int[] TwoSum(int[] nums, int target)
        {
            int[] answer = [0, 0];
            var tempNum = 0;
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var difference = target - nums[i];
                if (dict.TryGetValue(difference, out tempNum))
                {
                    return [dict[difference], i];
                }
                else
                {
                    if (dict.TryGetValue(nums[i], out tempNum))
                    {
                        continue;
                    }
                    dict.Add(nums[i], i);
                }

            }
            return answer;
        }



        //var answer = TwoSum([1, 3, 5, 1, 2, 0, 9, 8], 9);
        //Console.WriteLine(answer[0] + " " + answer[1]);
    }
}
