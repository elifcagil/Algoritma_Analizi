using System;

class maxAltDiziSort
{
    static int Program(int[] arr)
    {
        return Helper(arr, 0, arr.Length - 1);
    }

    static int Helper(int[] arr, int low, int high)
    {
        if (low == high)
            return arr[low];

        int mid = (low + high) / 2;

        // Sol, sağ ve ortadan geçen maksimumları bul
        int leftMax = Helper(arr, low, mid);
        int rightMax = Helper(arr, mid + 1, high);
        int crossMax = MaxCrossingSum(arr, low, mid, high);

        return Math.Max(leftMax, Math.Max(rightMax, crossMax));
    }

    static int MaxCrossingSum(int[] arr, int low, int mid, int high)
    {
        int leftSum = int.MinValue;
        int total = 0;
        for (int i = mid; i >= low; i--)
        {
            total += arr[i];
            if (total > leftSum)
                leftSum = total;
        }

        int rightSum = int.MinValue;
        total = 0;
        for (int i = mid + 1; i <= high; i++)
        {
            total += arr[i];
            if (total > rightSum)
                rightSum = total;
        }

        return leftSum + rightSum;
    }

    static void Main()
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine("Maksimum Alt Dizi Toplamı: " + Program(arr));
    }
}
