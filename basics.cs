//C# program to create gray code.

using System;

class Program
{
    public static int CreateGraycode(int num)
    {
        int gray = 0;

        gray = num ^ (num >> 1);

        return gray;
    }

    static void Main(string[] args)
    {
        int loop = 0;

        Console.WriteLine("Number\tGray Code");

        for (loop = 0; loop < 5; loop++)
        {
            Console.WriteLine(string.Format("{0}\t{1}", loop, Convert.ToString((int)CreateGraycode(loop), 2)));
        }
    }
}
