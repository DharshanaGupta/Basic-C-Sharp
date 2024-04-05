using System;
namespace Switchcase;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number1:");
        double num1=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number2:");
        double num2=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter option");
        char option=char.Parse(Console.ReadLine());
        switch(option)
        {
            case '+':
            {
                Console.WriteLine(num1+num2);
                break;
            }
            case '-':
            {
                Console.WriteLine(num1-num2);
                break;
            }
            case '*':
            {
                Console.WriteLine(num1*num2);
                break;
            }
            case '/':
            {
                Console.WriteLine(num1/num2);
                break;
            }
            case '%':
            {
                Console.WriteLine(num1%num2);
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Input");
                break;
            }
        }
    }
}
