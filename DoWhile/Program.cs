using System;
namespace DoWhile;
class Program 
{
    public static void Main(string[] args)
    {
        string option;
        do{
            Console.WriteLine("Enter number:");
            int number=int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.Write("Do you need to check for another number? yes/no");
            option=Console.ReadLine();
            if(option!="yes" && option!="no")
            {
                Console.WriteLine("Invalid input");
                
            }
            while(option!="no")
                {
                    Console.Write("Do you need to check for another number? yes/no");
                    option=Console.ReadLine();
                }
            
            
        }while(option=="yes");
    }

}
