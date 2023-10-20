namespace myLeetCodeSolutions.String;

/**
 * [](){}
 * {[()]}
 * {[][][]}
 */
public class ValidParentheses
{
    public bool isValid(string s)
    {
        // if input lenght is an odd number,
        // which mean there is as least 1 pair is uncompleted
        if (s.Length % 2 == 1)
        {
            return false;
        }

        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ')' )
            {
                if (stack.Count > 0 && stack.Peek() == '(')
                    stack.Pop();
                else return false;
            }
            else if (s[i] == ']' )
            {
                if (stack.Count > 0 && stack?.Peek() == '[')
                    stack.Pop();
                else return false;
            }
            else if (s[i] == '}' )
            {
                if (stack.Count > 0 && stack?.Peek() == '{')
                    stack.Pop();
                else return false;
            }
            else
            {
                stack.Push(s[i]);
            }
            
        }

        GC.Collect();
        GC.WaitForPendingFinalizers();
        return stack.Count == 0;
    }
}