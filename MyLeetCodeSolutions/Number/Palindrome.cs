namespace myLeetCodeSolutions.Number;

public class Palindrome
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        int revervedNumber = x;
        int IDoNotKnowWhatNameForThisOne = (int)Math.Pow(10,(int)Math.Log10(x));

        while (IDoNotKnowWhatNameForThisOne > 0)
        {
            if (x % 10 != revervedNumber / IDoNotKnowWhatNameForThisOne)
            {
                return false;
            }

            x /= 10;
            revervedNumber %= IDoNotKnowWhatNameForThisOne;
            IDoNotKnowWhatNameForThisOne /= 10;
        }

        return true;
    }
}