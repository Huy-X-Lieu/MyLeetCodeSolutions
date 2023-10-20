using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace myLeetCodeSolutions.String;

public class StringToInt
{
    public static int Solution(string s)
    {
        // trim all space at the front and end of the string
        string strNumber = s.Trim();
        int numberStartIndex = -1;
        int strNumberLength = 0;
        int result = 0;

        for (int i = 0; i < strNumber.Length; i++)
        {
            if (char.IsDigit(strNumber[i]) == false && 
                strNumber[i] != '-' &&
                strNumber[i] != '+' &&
                strNumber[i] != ' ')
            {
                return result;
            }

            if (char.IsDigit(strNumber[i]))
            {
                break;
            }
        }
        
        // find location of the first digit
        for (int i = 0; i < strNumber.Length; i++)
        {
            if (char.IsDigit(strNumber[i]))
            {
                numberStartIndex = i;
                strNumberLength = 1;
                break;
            }
        }

        if (strNumberLength == 0)
        {
            return result;
        }
        // check the character in front of the first digit (if any) to see if it is "-"
        if (numberStartIndex > 0)
        {
            if (strNumber[numberStartIndex - 1] == '-')
            {
                numberStartIndex -= 1;
            }
        }
        // loop to check the next characters after the first digit is a digit and store that location if it is a digit, stop if any is not a digit
        for (int i = numberStartIndex + 1; i < strNumber.Length; i++)
        {
            if (char.IsDigit(strNumber[i]))
                strNumberLength = i - numberStartIndex + 1;
            else break;
        }
        // get the substring contain the number include the "-"
        strNumber = strNumber.Substring(numberStartIndex, strNumberLength);
        strNumber = RemoveUnneccessaryZero(strNumber);

        // convert the max and min value of INT to string
        string maxIntStr = Int32.MaxValue.ToString();
        string minIntStr = Int32.MinValue.ToString();

        if (strNumber.StartsWith('-'))
        {
            if (strNumber.Length < minIntStr.Length ||
                strNumber.CompareTo(minIntStr) == 0)
            {
                result = Int32.Parse(strNumber);
            }
            else if (strNumber.Length == minIntStr.Length &&
                     strNumber.CompareTo(minIntStr) < 0)
            {
                result = Int32.Parse(strNumber);
            }
            else
            {
                result = Int32.MinValue;
            }
        }
        else
        {
            if (strNumber.Length < maxIntStr.Length ||
                strNumber.CompareTo(maxIntStr) == 0)
            {
                result = Int32.Parse(strNumber);
            }
            else if (strNumber.Length == minIntStr.Length &&
                     strNumber.CompareTo(maxIntStr) < 0)
            {
                result = Int32.Parse(strNumber);
            }
            else
            {
                result = Int32.MaxValue;
            }
        }
        // compare the substring with max and min INT (string)

        return result;
    }

    private static string RemoveUnneccessaryZero(string number)
    {
        bool isNegative = number.StartsWith('-');
        StringBuilder onlyNumber = new StringBuilder(number.Trim('-'));

        // get the last index of leading zeros
        for (int i = 0; i < onlyNumber.Length; i++)
        {
            if (onlyNumber[i] == '0')
            {
                onlyNumber.Remove(0, 1);
                i--;
            }
            else
            {
                break;
            }
        }

        onlyNumber.Insert(0, isNegative ? "-" : "");

        return onlyNumber.ToString();
    }
}