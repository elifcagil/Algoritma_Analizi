using System;

class InsertionSort
{
    static void Program(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i]; // Yerleştirilecek eleman
            int j = i - 1;

            // Key'den büyük elemanları sağa kaydır
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key; // Key'i doğru pozisyona yerleştir
        }
    }

    static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6 };
        Console.WriteLine("Sıralanmadan önce:");
        Console.WriteLine(string.Join(", ", arr));

        Program(arr);
        
        Console.WriteLine("Sıralandıktan sonra:");
        Console.WriteLine(string.Join(", ", arr));
    }
}

