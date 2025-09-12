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
            int dupCounter = 0;
            int current = int.MinValue;

            for (int i = 0; i < nums.Length - dupCounter; i++)
            {
                if (nums[i] != current)
                {
                    current = nums[i];
                } else
                {
                    for (int j = i; j < nums.Length - dupCounter - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    dupCounter++;
                    i--;
                }
            }

            return nums.Length - dupCounter;
        }
    }
}