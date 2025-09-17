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
            //if (nums.Count() == 0) {  return 0; }
            int left = 0;
            int right = nums.Length - 1;
            int mid = 0;

            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                } else if (nums[mid] > target)
                {
                    
                    if (right == mid + 1) { return mid + 1; }
                    right = mid + 1;
                } else
                {
                    
                    if (left == mid + 1) { return mid + 1; }
                    left = mid + 1;
                }
                
            }


            return mid + 1;
        }
    }
}
