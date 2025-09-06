namespace LeetCode.Problems
{
    internal class Sqrt()
    {
        // given num x return it's sqaure root rounded down to it's nearest int
        // no negatives

        public int MySqrt(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            if (x < 4)
            {
                return 1;
            }
            int left = 0;
            int right = x / 2;
            int middle = 0;
            int sqaure = 0;

            while (left < right)
            {
                middle = left + ((right - left) / 2);
                sqaure = x / middle;
                if (sqaure == middle)
                {
                    return middle;
                }
                else if (sqaure > middle)
                {
                    if (left == middle)
                    {
                        return middle;
                    }
                    left = middle;
                }
                else if (sqaure < middle)
                {
                    right = middle;
                }
            }


            return 0;
        }
    }
}