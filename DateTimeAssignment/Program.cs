using System;
using System.Globalization;
namespace DateTimeAssignment;
class Program
{
    public static void Main(string[] args)
    {
        //question1
        // DateTime date=new DateTime(2021,8,10,10,40,32);
        // Console.WriteLine(date.Year);
        // Console.WriteLine(date.Month);
        // Console.WriteLine(date.Day);
        // Console.WriteLine(date.Hour);
        // Console.WriteLine(date.Minute);
        // Console.WriteLine(date.Second);

        //question2

        // DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss tt",null);
        // string d=date1.ToString();
        // string[] arr=d.Split('/',' ',':');
        // for(int i=arr.Length-1;i>=0;i--)
        // {
        //     Console.Write(arr[i]+" ");
        // }

        //question3
        // DateTime input =DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        // Console.WriteLine(input.Year);
        // Console.WriteLine(input.Month);
        // Console.WriteLine(input.Day);

        
        
        long n=long.Parse(Console.ReadLine());
        int k=int.Parse(Console.ReadLine());
        int r=0;
        int count=0;
        while(n!=0)
        {
            count++;
            long n1=n%10;
            if(n1<=k)
            {
                r++;
            }
            else{
                Console.WriteLine("no");
                break;
                }
            n/=10;
        }
        if(r==count)
        {
            Console.WriteLine("yes");
        }
        
        
            
        

        
        
        
    }
}