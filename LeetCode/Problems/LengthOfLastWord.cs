namespace LeetCode.Problems
{
    public class LengthOfLastWord {
        public int GetWordLength(string s)
        {
            var wordArray = s.Split(' ');
            return wordArray.Last(w => w.Length > 0).Length;
        }
    }
}