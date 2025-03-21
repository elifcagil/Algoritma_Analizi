using System;

class MaxSubArraySolver
{
    public static int MaxSubArray(int[] nums)
    {
        int maxSum = nums[0];
        int currentSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }
        return maxSum;
    }

    static void Main()
    {
        int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine("Max Subarray Sum: " + MaxSubArray(nums));
    }
}