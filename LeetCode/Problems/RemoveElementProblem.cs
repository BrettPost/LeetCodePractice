

namespace LeetCode.Problems
{
    internal class RemoveElementProblem
    {
        // remove all val's from nums (in-place algo)
        // order can be changed
        // number of non-val's in nums is 'k'
        // return k
        // alter nums such that the first k elements are not val (elements after this do not matter, and size does not matter

        //int[] nums = [3, 2, 2, 3];
        //int value = 3;
        //RemoveElementProblem removeElementProblem = new();
        //var result = removeElementProblem.RemoveElement(nums, value);
        //Console.WriteLine(result);


        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
