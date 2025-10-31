namespace LeetCode.Practice
{
    public class BinarySearch
    {
        public int[] nums = [2, 4, 7, 9];
        public int value = 8;

        public int Example(int[] numArray, int find)
        {
            int left = 0;
            int right = numArray.Length - 1;
            int mid = 0;

            while (left <= right)
            {
                mid = left + ((right - left) / 2);

                if (numArray[mid] == find)
                {
                    return mid;
                }
                else if (numArray[mid] < find)
                {
                    left = mid + 1;
                }
                else if (numArray[mid] > find)
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}