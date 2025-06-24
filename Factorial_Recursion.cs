
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(factorial(5));
    }
    
    public static int factorial(int num){
        if(num==0)
            return 1;
        else
        {
            return num * factorial(num-1);
        }
    }
        
}
