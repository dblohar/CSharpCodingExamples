/* METHOD 1 */
public static bool IsPrime(int num){
        if(num<=1)
            return false;
        for(int i=2;i*i<=num;i++)
        {
            if(num%i==0)
                return false;
        }
        return true;
    }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*    METHOD 2   */


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int num = 100;
       Console.WriteLine($"Is {num} prime number? => {IsPrime(num)}");
    }
    public static bool IsPrime(int num)
    {
        if(num<=1)
            return false;
        if(num==2)
            return true;
        if(num % 2 == 0)
            return false;
        int limit = (int)Math.Sqrt(num);
        
        for(int i = 3;i< limit; i += 2)
        {
            if(num%i==0)
            {
                return false;
            }
        }
        
        return true;
    }
}
