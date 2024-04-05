using System;
namespace Array;
class Program 
{
    public static void Main(string[] args)
    {
        string[] arr=new string[5];
        Console.WriteLine("Enter the  5names:");
        for(int i=0;i<5;i++)
        {
            arr[i]=Console.ReadLine();
        }
        for(int i=0;i<5;i++)
        {
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine("Enter name to search:");
        string search_name=Console.ReadLine();
        for(int i=0;i<5;i++)
        {
            if(arr[i]==search_name)
            {
                Console.WriteLine("The name is Present in the array"+"index is:"+i);
            }
            else if(i==arr.Length){
                Console.WriteLine("The name is not present in array");
            }
        }
        string res="";
        foreach(string i in arr)
        {
            if(i==search_name)
            {
                //Console.WriteLine("The name is Present in the array");
                res="true";

            }
            
        }
        if(res=="true")
        {
            Console.WriteLine("The name is Present in the array");

        }
        else
        {
            Console.WriteLine("The name is Not Present in the array");
        }
    }
}
