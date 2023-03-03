using System;
namespace BracketChecker
{
	public class BracketChecker
    {
        public static bool Solution(string input)
        {
            Stack<char> brackets = new Stack<char>();
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {
                {'(', ')' },
                {'{', '}' },
                {'[', ']' },
                {'<', '>' },
            };

            try
            {
                foreach (var mark in input)
                {
                    if (bracketPairs.Keys.Contains(mark))
                        brackets.Push(mark);
                    else if (bracketPairs.Values.Contains(mark))
                    {
                        if (mark == bracketPairs[brackets.First()])
                            brackets.Pop();
                        else
                            return false;
                    }
                    else
                        continue;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return brackets.Count() == 0 ? true : false;
        }
    }
}

