using System;
namespace StringManipulation;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter main string:");
        string longstring=Console.ReadLine();
        Console.WriteLine("Enter substring:");
        string serachstring=Console.ReadLine();
        string[] s=longstring.Split(serachstring);
        int count=0;
        for(int i=0;i<s.Length;i++)
        {
            //Console.WriteLine(s[i]);
            count++;
        }
        Console.WriteLine(count-1);
    }
}