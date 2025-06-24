using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int[] arr = new int[] {20,0,1,3,4,6,12,10,9,1,21};
       Console.WriteLine(FindMaxInArray(arr));
    }
    
    public static int FindMaxInArray(int[] arr)
    {
        int max = arr[0];
        for(int i = 1; i < arr.Length;i++)
        {
            if(arr[i]>max)
                max = arr[i];
        }
        return max;
    }
        
}
