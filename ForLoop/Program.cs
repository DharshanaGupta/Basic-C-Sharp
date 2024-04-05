using System;
namespace ForLoop;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter limit1");
        int limit1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter limit2");
        int limit2=int.Parse(Console.ReadLine());
        int sum=0;
        for(int i=limit1;i<=limit2;i++)
        {
            int square=i*i;
            sum+=square;
        }
        Console.WriteLine(sum);
    }
}
