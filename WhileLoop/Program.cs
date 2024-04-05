using System;
namespace WhileLoop;
class Program 
{
    public static void Main(string[] args)
    {
        //Question1
        int i=0;
        while(i<=25)
        {
            if(i%2==0)
            {
                Console.WriteLine(i);
            }
            i++;
        }

        //Question2
        Console.WriteLine("Enter a number:");
        int num=0;
        bool valid_num=int.TryParse(Console.ReadLine(),out num);
        while(!valid_num)
        {
            Console.WriteLine("Invalid input format. Please enter the input in number format");
            valid_num=int.TryParse(Console.ReadLine(),out num);
        }
        Console.WriteLine("Valid number:"+num);


    }
}
