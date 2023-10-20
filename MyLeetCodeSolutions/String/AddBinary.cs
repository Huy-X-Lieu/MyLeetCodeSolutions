using System.Text;

namespace myLeetCodeSolutions.String;

public class AddBinary
{
    public string Add(string a, string b)
    {
        StringBuilder fNum = new StringBuilder(a.Length >= b.Length ? a : b);
        StringBuilder sNum = new StringBuilder(a.Length < b.Length ? a : b);
        int remain = 0;

        while (sNum.Length < fNum.Length)
        {
            sNum.Insert(0, '0');
        }

        for (int i = fNum.Length - 1; i >= 0; i--)
        {
            if (fNum[i] == '0' && sNum[i] == '0' && remain == 1)
            {
                fNum[i] = '1';
                remain = 0;
            }
            else if (fNum[i] == '1' && sNum[i] == '1')
            {
                if (remain == 0)
                    fNum[i] = '0';
                else
                    fNum[i] = '1';
                remain = 1;
            }
            else if(fNum[i] == '1' ^ sNum[i] == '1')
            {
                if (remain == 0)
                    fNum[i] = '1';
                else
                {
                    fNum[i] = '0';
                    remain = 1;
                }
            }
        }

        if (remain == 1)
        {
            fNum.Insert(0, '1');
        }

        return fNum.ToString();
    }
}