namespace LeetCode.Problems
{
    internal class RemoveDuplicatesFromSortedArray()
    {
        //int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        //RemoveDuplicatesFromSortedArray removeDuplicatesFromSortedArray = new();
        //Console.WriteLine(removeDuplicatesFromSortedArray.RemoveDuplicates(nums));

        //sorted ascending
        //in-place
        // remove dups
        // maintain order
        // return unique elements (k)

        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int j = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[j] != nums[i])
                {
                    nums[++j] = nums[i];
                }
            }

            return j + 1;
        }
    }
}