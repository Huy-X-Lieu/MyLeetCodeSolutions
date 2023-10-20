using System.Text;

namespace myLeetCodeSolutions.String;

public class IntToRoman
{
    public string Solution(int num)
    {
        StringBuilder roman = new StringBuilder();

        while (num - 1000 >=  0)
        {
            roman.Append('M');
            num -= 1000;
        }

        if (num - 900 >= 0)
        {
            roman.Append("CM");
            num -= 900;
        }

        if (num - 500 >= 0)
        {
            roman.Append('D');
            num -= 500;
        }

        if (num - 400 >= 0)
        {
            roman.Append("CD");
            num -= 400;
        }

        while (num - 100 >= 0)
        {
            roman.Append('C');
            num -= 100;
        }

        if (num - 90 >= 0)
        {
            roman.Append("XC");
            num -= 90;
        }

        if (num - 50 >= 0)
        {
            roman.Append('L');
            num -= 50;
        }

        if (num - 40 >= 0)
        {
            roman.Append("XL");
            num -= 40;
        }

        while (num - 10 >= 0)
        {
            roman.Append('X');
            num -= 10;
        }

        if (num - 9 == 0)
        {
            roman.Append("IX");
            num -= 9;
        }

        if (num - 5 >= 0)
        {
            roman.Append('V');
            num -= 5;
        }

        if (num - 4 == 0)
        {
            roman.Append("IV");
            num -= 4;
        }

        while (num - 1 >= 0)
        {
            roman.Append('I');
            num--;
        }

        return roman.ToString();
    }
}