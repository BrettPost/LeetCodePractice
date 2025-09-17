using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                } else if (nums[mid] > target)
                {
                    right = mid - 1;
                } else
                {   
                    left = mid + 1;
                }
                
            }
            return left;
        }
    }
}
