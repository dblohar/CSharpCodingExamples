using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      Console.WriteLine(IsPalindrome(101));
    }
    
    public static bool IsPalindrome(int num){
        Console.WriteLine(num);
        int tempNum = num;
        int revNum = 0;
        while(tempNum>0)
        {
            int digit = tempNum % 10;
            revNum = (revNum * 10) + digit;
            tempNum = tempNum / 10;
            
        }
        Console.WriteLine(revNum);
        if(num == revNum)
            return true;
        return false;
        
    }
        
}
