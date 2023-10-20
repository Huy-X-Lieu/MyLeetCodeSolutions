namespace myLeetCodeSolutions.Array;

public class SearchInsertPosition
{
    public int Solution(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int mid = right / 2;

        if (nums[right] < target)
            return right + 1;
        if (nums[right] == target)
            return right;
        if (nums[left] >= target)
            return 0;

        while (left <= right)
        {
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
                mid = (right + left) / 2;
            }
            else if(nums[mid] > target)
            {
                right = mid - 1;
                mid = (right + left) / 2;
            }
        }

        if (left >= right && nums[mid] < target)
            return mid + 1;
        if (left >= right && nums[mid] > target)
            return mid;

        return -1;
    }
}