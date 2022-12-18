using System;
class Program
{
    private static void generatePermute(String str, int l, int r)
    {
        if (l == r-1)
            Console.WriteLine(str);
        else
            for (int i = l; i <= r; i++)
            {
                str = swap(str, l, i);
                generatePermute(str, l + 1, r);
                str = swap(str, l, i);
            }
    }

    public static String swap(String a, int i, int j)
    {
        char ch;
        char[] b = a.ToCharArray();
        ch = b[i];
        b[i] = b[j];
        b[j] = ch;
        string s = new string(b);
        return s;
    }
    public static void Main(string[] args)
    {
        String str = "ABC";
        int n = str.Length;
        Console.WriteLine("All the permutation of the string are: ");
        generatePermute(str, 0, n);
    }
}