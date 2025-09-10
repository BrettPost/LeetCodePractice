

namespace LeetCode.Problems
{
    internal class PalindromeNumber
    {

        //PalindromeNumber palindromeNumber = new();
        //Console.WriteLine(palindromeNumber.IsPalindrome(-2));

        public bool IsPalindrome(int x)
        {
            var numString = x.ToString();
            var numLength = numString.Length;
            if (numLength == 1) { return true; }
            if (numString[0] == '-') { return false; }

            Stack<char> numbers = new();

            for(var i = 0; i < numLength; i++)
            {
                if (i < numLength / 2)
                {
                    numbers.Push(numString[i]);
                } else if (i == numLength / 2 && numLength % 2 == 1) {
                    continue;
                } else
                {
                    var temp = numbers.Pop();
                    if (temp != numString[i])
                    {
                        return false;
                    }
                }
                    
            }

            return true;

            // Try reversing the array
        }
    }
}
