using System;
public class Program
{
    public void sort(int[] a)
    {
        int n = a.Length;
        for(int i =1; i < n; i++)
        {
            int key = a[i];
            int j = i - 1;
            while(j >= 0 && a[j] > key)
            {
                a[j + 1] = a[j];
                j--;
            }
            a[j + 1] = key;
        }
    }
    static void printArray(int[] a)
    {
        int n = a.Length;
        for(int i =0; i < n; i++)
        {
            Console.WriteLine(a[i] + " ");
        }

    }
    public static void Main()
    {
        int[] a = { 12, 11, 5, 4, 7, 3, 2, 1};
        Program insert = new Program();
        insert.sort(a);
        printArray(a);
    }
}