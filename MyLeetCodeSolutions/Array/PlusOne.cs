namespace myLeetCodeSolutions.Array;

public class PlusOne
{
    public int[] Solution(int[] digits)
    {
        /*
         * create a variable called "remain" and give it value of 1
         * loop through the array and add the "remain" to each cell 
         * if the sum is less than 10, remain = 0, return the array
         * if the sum is 10, remain = 1, continue the loop
         */

        int remain = 1;

        for (int i = digits.Length - 1; i >= 0 && remain == 1; i--)
        {
            if (digits[i] + remain == 10)
                digits[i] = 0;
            else
            {
                digits[i] += 1;
                remain = 0;
                break;
            }
        }

        if (remain == 1)
        {
            int[] one = { 1 };
            digits = one.Concat(digits).ToArray();
        }

        return digits;
    }
}