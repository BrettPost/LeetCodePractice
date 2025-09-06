namespace LeetCode.Problems
{
    internal class Sqrt()
    {
        // given num x return it's sqaure root rounded down to it's nearest int
        // no negatives

        public int MySqrt(int x)
        {
            if (x < 2) { return x; }

            int left = 1;
            int right = x / 2;
            int result = 0;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                long sqaure = (long)middle * middle;

                if (sqaure == x)
                {
                    return middle;
                }
                else if (sqaure < x)
                {
                    result = middle;
                    left = middle + 1;
                }
                else 
                {
                    right = middle - 1;
                }
            }


            return result;
        }
    }
}