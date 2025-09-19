using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class AddBinaryProblem
    {
        // AddBinaryProblem addBinaryProblem = new();
        // var result = addBinaryProblem.AddBinary("", "");
        // Console.WriteLine(result);

        public string AddBinary(string a, string b)
        {
            if (a.Length == 0 && b.Length == 0)
            {
                return "0";
            }
            var length = int.Max(a.Length, b.Length);
            var answer = "";
            bool carry = false;

            for (int i = 0; i < length; i++)
            {
                int addPos = 0;
                if (a.Length <= i)
                {
                    addPos = carry ? b[b.Length - 1 - i] - '0' + 1 : b[b.Length - 1 - i] - '0';

                    if (addPos == 0)
                    {
                        answer = "0" + answer;
                        carry = false;
                    }
                    else if (addPos == 1)
                    {
                        answer = "1" + answer;
                        carry = false;
                    }
                    else if (addPos == 2)
                    {
                        answer = "0" + answer;
                        carry = true;
                    }
                }
                else if (b.Length <= i)
                {
                    addPos = carry ? a[a.Length - 1 - i] - '0' + 1 : a[a.Length - 1 - i] - '0';

                    if (addPos == 0)
                    {
                        answer = "0" + answer;
                        carry = false;
                    }
                    else if (addPos == 1)
                    {
                        answer = "1" + answer;
                        carry = false;
                    }
                    else if (addPos == 2)
                    {
                        answer = "0" + answer;
                        carry = true;
                    }
                }
                else
                {
                    addPos = carry ? a[a.Length - 1 - i] - '0' + (b[b.Length - 1 - i] - '0') + 1 : a[a.Length - 1 - i] - '0' + (b[b.Length - 1 - i] - '0');

                    if (addPos == 0)
                    {
                        answer = "0" + answer;
                        carry = false;
                    }
                    else if (addPos == 1)
                    {
                        answer = "1" + answer;
                        carry = false;
                    }
                    else if (addPos == 2)
                    {
                        answer = "0" + answer;
                        carry = true;
                    }
                    else if (addPos == 3)
                    {
                        answer = "1" + answer;
                        carry = true;
                    }
                }
            }

            
            if (carry)
            {
                return "1" + answer;
            }
            return answer;
        }
    }
}
