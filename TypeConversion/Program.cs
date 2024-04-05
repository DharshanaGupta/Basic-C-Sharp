using System;
namespace TypeConversion;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string name=Console.ReadLine();
        Console.WriteLine("Enter age:");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter mark of subjet1:");
        float mark1=float.Parse(Console.ReadLine());
        Console.WriteLine("Enter mark of subject2:");
        float mark2=float.Parse(Console.ReadLine());
        Console.WriteLine("Enter mark of subject3:");
        float mark3=float.Parse(Console.ReadLine());
        Console.WriteLine("Enter Grade:");
        char grade=char.Parse(Console.ReadLine());
        Console.WriteLine("Enter mobile number:");
        long m_number = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter Mail Id");
        string mailid = Console.ReadLine();
        float total=mark1+mark2+mark3;
        float avg=total/3;
        Console.WriteLine("Trainee Details Are:");
        Console.WriteLine("Name:"+name);
        Console.WriteLine("Age:"+age);
        Console.WriteLine("Mobile:"+m_number);
        Console.WriteLine("Marks1:"+mark1);
        Console.WriteLine("Marks2:"+mark2);
        Console.WriteLine("Marks3:"+mark3);
        Console.WriteLine("Total:"+total);
        Console.WriteLine("Average:"+avg);
        Console.WriteLine("Grade:"+grade);
        Console.WriteLine("Mail Id:"+mailid);
        //interpolation method
        Console.WriteLine($"Name:{name} \n Age:{age}");

    }
}
