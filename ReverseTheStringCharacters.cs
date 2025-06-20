/*
Reverse the character of string.

if "Deepak" is string then output would be "kapeed"
*/
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string Name = "Deepak";
        char[] reverse = Name.ToCharArray();
        for(int i = 0,j=Name.Length-1;i<j;i++,j--)
        {
            reverse[i] = Name[j];
            reverse[j] = Name[i];
        }
        Console.WriteLine(new string(reverse));
    }
}
