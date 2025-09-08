

namespace LeetCode.Problems
{
    internal class RemoveElementProblem
    {
        // remove all val's from nums (in-place algo)
        // order can be changed
        // number of non-val's in nums is 'k'
        // return k
        // alter nums such that the first k elements are not val (elements after this do not matter, and size does not matter


        public int RemoveElement(int[] nums, int val)
        {
            int k = nums.Length - 1;

            for (int i = 0; i < k + 1; i++)
            {
                while (nums[i] == val)
                {
                    if (i == k) { break; }
                    //swap
                    int temp = nums[i];
                    nums[i] = nums[k];
                    nums[k] = temp;
                    k--;
                }
            }

            return k + 1;
        }
    }
}
