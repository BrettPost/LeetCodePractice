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
            if (n <= 3) { return n; }
            return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }
    }
}
