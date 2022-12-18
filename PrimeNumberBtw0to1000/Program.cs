using System;
public class Program
{
    public static void Main()
    {
        int num, i, j, stno, enno;
        Console.WriteLine("Input starting number of range: ");
        stno= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input ending number of range: ");
        enno = Convert.ToInt32(Console.ReadLine());
        for(num = stno; num<=enno;num++)
        {
            j = 0;
            for(i=2;i<=num/2;i++)
            {
                if(num%i==0)
                {
                    j++;
                    break;
                }
            }
            if(j ==0 && num!=1)
            {
                Console.WriteLine("{0}", num);
            }
        }
    }
}