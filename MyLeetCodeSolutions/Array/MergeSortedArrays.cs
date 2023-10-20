using System.Runtime.InteropServices;

namespace myLeetCodeSolutions.Array;

public class MergeSortedArrays
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0)
        {
            return;
        }

        if (m == 0)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[i] = nums2[i];
            }

            return;
        }

        int index = m + n - 1;
        m--;
        n--;
        while (index >= 0 && m >= 0 && n>= 0)
        {
            if (nums1[m] >= nums2[n])
            {
                nums1[index] = nums1[m];
                if (index > m)
                {
                    nums1[m] = 0;
                }
                m--;
            }
            else
            {
                nums1[index] = nums2[n];
                n--;
            }

            index--;
        }

        while ( index >= 0 && m < 0 && n >= 0)
        {
            nums1[index--] = nums2[n--];
        }
    }
}