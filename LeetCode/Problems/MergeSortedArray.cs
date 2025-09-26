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
            for (var i = 0; i < n; i++)
            {
                int j = nums1.Length - 1 - (n - 1 - i);
                while (j > 0 && nums1[j - 1] > nums2[i])
                {
                    nums1[j] = nums1[j - 1];
                    j--;
                }
                nums1[j] = nums2[i];
            }

            //print(nums1);
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