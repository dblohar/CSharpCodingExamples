
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Reverse("Deepak"));
    }
    
    public static string Reverse(string str){
        
        char[] s = str.ToCharArray();
        
        Array.Reverse(s);
        
        return new string(s);
    }
  
        
}
