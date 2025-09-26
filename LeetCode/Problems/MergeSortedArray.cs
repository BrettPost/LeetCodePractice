namespace LeetCode.Problems
{
    public class MergeSortedArray
    {

        // nums1 -> num of elements m
        // nums2 -> num of elements n
        // Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        // Output: [1,2,2,3,5,6]

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (var i = 0; i < n; i++)
            {
                nums1 = FindPos(nums1, nums2[i], n - 1 - i);
            }

            print(nums1);
        }

        private int[] FindPos(int[] nums, int val, int shift)
        {
            var left = 0;
            var right = nums.Length - 1 - shift;
            var mid = 0;

            while (left <= right)
            {
                mid = left + (right - left) / 2;

                if (nums[mid] == val)
                {
                    for (var i = nums.Length - 1 - shift; i > mid; i--)
                    {
                        nums[i] = nums[i - 1];
                    }
                    nums[mid] = val;
                    return nums;
                }
                else if (nums[mid] > val)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            for (var i = nums.Length - 1 - shift; i > mid; i--)
            {
                nums[i] = nums[i - 1];
            }
            nums[mid] = val;
            return nums;
        }

        private void print(int[] nums)
        {
            //remove before submitting
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}