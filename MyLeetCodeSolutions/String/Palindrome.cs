using System.Text;

namespace myLeetCodeSolutions.String;

public class Palindrome
{
    public bool IsPalindrome(string s)
    {
        StringBuilder Bstr = new StringBuilder();
        foreach (char c in s.ToCharArray())
        {
            if (char.IsLetter(c) || char.IsDigit(c))
            {
                Bstr.Append(c);
            }
        }

        string str = Bstr.ToString().ToLower();
        
        int start = 0;
        int strLength = str.Length;
        int end = str.Length - 1;

        while (start <= end)
        {
            if (str[start++] != str[end--])
            {
                return false;
            }
        }

        return true;
    }
}