using System;

class BubbleSort
{
    static void Program(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            bool swapped = false; // Optimizasyon için swap kontrolü
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap işlemi
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) // Hiç swap yapılmadıysa liste sıralıdır
                break;
        }
    }

    static void Main()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Sıralanmadan önce:");
        Console.WriteLine(string.Join(", ", arr));

        Program(arr);
        
        Console.WriteLine("Sıralandıktan sonra:");
        Console.WriteLine(string.Join(", ", arr));
    }
}
