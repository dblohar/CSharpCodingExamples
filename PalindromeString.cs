using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      Console.WriteLine(IsPalindrome("NAN"));
    }
    
    public static bool IsPalindrome(string str)
    {
        for(int left = 0,right = str.Length-1;left<right;left++,right--)
        {
            if(str[left]!=str[right])
            {
                return false;
            }
            else
                return true;
        }
        return false;
    }
        
}
