namespace LeetCode.Problems
{
    public class LengthOfLastWord {

        // LengthOfLastWord lengthOfLastWord = new();
        // var lengthOfWord = lengthOfLastWord.GetWordLength("Hellofadfad  ");
        // Console.WriteLine(lengthOfWord);
        public int GetWordLength(string s)
        {
            var wordArray = s.Split(' ');
            return wordArray.Last(w => w.Length > 0).Length;
        }
    }
}