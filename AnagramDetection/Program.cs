using System;
class Program
{
    public class Anagram
    {
        public bool areAnagram(string firstString, string secondString)
        {
            if(firstString.Length != secondString.Length)
            {
                return false;
            }
            char[] firstCharsArray = firstString.ToLower().ToCharArray();
            char[] secondCharArray = secondString.ToLower().ToCharArray();
            Array.Sort(firstCharsArray);
            Array.Sort(secondCharArray);
            for(int i=0;i<firstCharsArray.ToArray().Length;i++)
            {
                if (firstCharsArray[i].ToString()!= secondCharArray[i].ToString())
                {
                    return false;
                }
            }
            return true;
        }
    }
    static void Main(string[] args)
    {
        string firstString, secondString;
        Console.WriteLine("Enter first string");
        firstString= Console.ReadLine();
        Console.WriteLine("Enter second string");
        secondString = Console.ReadLine();
        Anagram anagram = new Anagram();
        if(anagram.areAnagram(firstString, secondString)== true) 
        {
            Console.WriteLine("Both string are anagram string.");
        }
        else
        {
            Console.WriteLine("Both string are not anagram string.");
        }
        Console.ReadLine();
    }
}