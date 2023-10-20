namespace myLeetCodeSolutions.Number;

public class TwoSum
{
    public int[] Solution(int[] nums, int target)
    {
        int[] result =new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] + nums[i] == target)
                {
                    result[0] = i; result[1] = j;
                }
            }
        }
        GC.Collect();
        GC.WaitForPendingFinalizers();
        return result;
    }
}