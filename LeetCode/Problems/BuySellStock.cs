namespace LeetCode.Problems
{
    internal class BuySellStock
    {
        // BuySellStock buySellStock = new();
        // var ans = buySellStock.maxProfit([100, 180, 260, 310, 40, 535, 695]);
        // Console.WriteLine(ans);

        public int maxProfit(int[] prices)
        {
            int res = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    res += prices[i] - prices[i - 1];
            }

            return res;
        }
    }
}