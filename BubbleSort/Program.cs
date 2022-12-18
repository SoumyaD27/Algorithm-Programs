using System;
public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 6, 9, 6, -1, 8 };
        int b;
        Console.WriteLine("Original array: ");
        foreach(int c in a)
            Console.WriteLine(c + " ");
        for(int i =0; i <= a.Length-2; i++)
        {
            for( int j =0; j<=a.Length-2;j++)
            {
                if (a[j] > a[j+1])
                {
                    b = a[j + 1];
                    a[j + 1] = a[j];
                    a[j] = b;
                }
            }
        }
        Console.WriteLine("\n" + "Sorted array: ");
        foreach (int c in a)
            Console.WriteLine(c + " ");

    }
}