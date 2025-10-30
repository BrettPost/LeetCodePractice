namespace LeetCode.Problems
{
    public class MergeSortedArray
    {

        //int[] nums1 = [1, 2, 3, 0, 0, 0];
        //int[] nums2 = [2, 5, 6];

        //int[] nums1 = [4, 5, 6, 0, 0, 0];
        //int[] nums2 = [1, 2, 3];
        //int m = 3;
        //int n = 3;

        //MergeSortedArray mergeSortedArray = new();
        //mergeSortedArray.Merge(nums1, m, nums2, n);

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int k = m + n - 1;
            int i = m - 1;
            int j = n - 1;

            while (j >= 0)
            {
                if (i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }
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