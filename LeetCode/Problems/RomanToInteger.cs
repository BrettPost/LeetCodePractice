namespace LeetCode.Problems
{
    internal class RomanToInteger
    {

        //six instances
        //I before V,X
        //X before L,C
        //C before D,M
        // I - 1
        // V - 5
        // X - 10
        // L - 50
        // C - 100
        // D - 500
        // M - 1000

        //RomanToInteger romanToInteger = new();
        //Console.WriteLine(romanToInteger.RomanToInt("IVX"));

        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanMap = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            int answer = 0;

            for(int i = 0; i < s.Length; i++)
            {
                string romanDouble = "";
                if (i < s.Length - 1)
                {
                    romanDouble = string.Concat(s[i], s[i + 1]);
                }
                
                if (romanDouble == "IV")
                {
                    answer += 4;
                    i++;
                } 
                else if (romanDouble == "IX")
                {
                    answer += 9;
                    i++;
                }
                else if (romanDouble == "XL")
                {
                    answer += 40;
                    i++;
                }
                else if (romanDouble == "XC")
                {
                    answer += 90;
                    i++;
                }
                else if (romanDouble == "CD")
                {
                    answer += 400;
                    i++;
                }
                else if (romanDouble == "CM")
                {
                    answer += 900;
                    i++;
                }
                else
                {
                    answer += romanMap[s[i]];
                }
                    
            }


            return answer;
        }
    }
}
