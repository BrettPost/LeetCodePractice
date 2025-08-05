using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    // s contains "(, ), {, }, [, ]"
    // Looking to validate string
    // Brackets must be closed in the correct order
    // Open brackets must be closed by the same type of brackets
    // every close bracket has a open bracket of the same type

    // Use Stack

    internal class ValidParentheses
    {
        public string testing = "{}]";
        public bool IsValid(string s)
        {
            if (s.Length < 2) { return false; }
            Stack<char> stack = new();

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                    continue;
                } else if (stack.Count == 0)
                {
                    return false;
                }

                // Dictionary could get rid of the switch code
                switch (stack.Pop())
                {
                    case '(':
                        if (s[i] != ')')
                        {
                            return false;
                        }
                        break;
                    case '{':
                        if (s[i] != '}')
                        {
                            return false;
                        }
                        break;
                    case '[':
                        if (s[i] != ']')
                        {
                            return false;
                        }
                        break;
                    default:
                        return false;
                }
            }

            if (stack.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
