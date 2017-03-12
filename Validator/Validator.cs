using System;
using System.Collections.Generic;

namespace ExpressionValidator
{
    public class Validator
    {
        private static readonly List<char> openBrakets = new List<char> { '{', '[', '(' };
        private static readonly List<char> closedBrakets = new List<char> { '}', ']', ')' };

        public static bool ValidateExpression(string expression)
        {
            Stack<char> stack = new Stack<char>();
            
            foreach (char character in expression)
            {
                if (openBrakets.Contains(character)) stack.Push(character);

                if (closedBrakets.Contains(character))
                {
                    var lastOpenedBraket = stack.Pop();
                    var indexOfLastOpendBraket = openBrakets.IndexOf(lastOpenedBraket);
                    if (character != closedBrakets[indexOfLastOpendBraket]) return false;
                }
            }
            
            return stack.Count==0;
        }
    }
}
