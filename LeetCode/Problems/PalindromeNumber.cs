

namespace LeetCode.Problems
{
    internal class PalindromeNumber
    {

        //PalindromeNumber palindromeNumber = new();
        //Console.WriteLine(palindromeNumber.IsPalindrome(-2));

        public bool IsPalindrome(int x)
        {
            var numString = x.ToString();
            if (numString[0] == '-') { return false; }

            Stack<char> numbers = new();

            for (var i = 0; i < numString.Length; i++)
            {
                if (numString[i] != numString[numString.Length - 1 - i])
                {
                    return false;
                }

            }

            return true;
        }
    }
}
