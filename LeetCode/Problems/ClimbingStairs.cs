using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class ClimbingStairs
    {
        // ClimbingStairs climbingStairs = new();
        // var result = climbingStairs.ClimbStairs(4);
        // Console.WriteLine(result);

        // 1=1
        // 2=2
        // 3=3
        // 4=5
        // 5=8

        public int ClimbStairs(int n)
        {
            if (n <= 1) return 1;
            int firstNum = 1, secondNum = 1, thirdNum = 0;
            for (int i = 2; i < n + 1; i++)
            {
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
            }
            return thirdNum;
        }
    }
}
