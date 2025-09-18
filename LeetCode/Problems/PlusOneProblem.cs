using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class PlusOneProblem
    {
        //increase the large digit

        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i] += 1;
                    if (digits[i] != 10) { return digits; }
                }
                else
                {
                    digits[i] = 0;
                }
            }
            return digits.Prepend(1).ToArray();
        }
    }
}
