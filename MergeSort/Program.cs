using System;
class Program
{
    void merge(int[] arr, int a, int b, int c)
    {
        int d1 = b - a + 1;
        int d2 = c - b;
        int[] L = new int[d1];
        int[] R = new int[d2];
        int i, j;
        for (i = 0; i < d1; i++)
            L[i] = arr[a + i];
        for (j = 0; j < d2; j++)
            R[j] = arr[b + 1 + j];
        i = 0; j = 0;
        int k = a;
        while (i < d1 && j < d2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }
        while (i < d1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }
        while (j < d2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }
    void sort(int[] arr, int a, int c)
    {
        if (a < c)
        {
            int b = a + (c - a) / 2;
            sort(arr, a, b);
            sort(arr, b + 1, c);
            merge(arr, a, b, c);
        }
    }
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
            Console.WriteLine(arr[i] + " ");
    }
    public static void Main(string[] args)
    {
        int[] arr = { 6, 9, 3, 5, 0, 10, 6, 7 };
        Console.WriteLine("Given Array");
        printArray(arr);
        Program merge = new Program();
        merge.sort(arr, 0, arr.Length - 1);
        Console.WriteLine("Sorted Array");
        printArray(arr);
    }
}