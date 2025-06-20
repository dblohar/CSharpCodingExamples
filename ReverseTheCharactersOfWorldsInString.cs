/*
Title: Reverse the Characters of Each Word in a String

Difficulty: Easy–Medium

Problem Statement:

Write a C# method that takes a sentence as input and returns a new string where each word's characters are reversed, but the word order and spacing remain unchanged.

A word is defined as a sequence of non-space characters.
Spaces between words should be preserved exactly as in the input.


Example:

Input:  "Hello World"
Output: "olleH dlroW"

Input:  "The sky is blue"
Output: "ehT yks si eulb"

Input:  " C# is  fun! "
Output: " #C si  !nuf "
*/
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string input = "C# is  fun!";
        string[] words = input.Split(' ');
        for(int i = 0;i < words.Length;i++)
        {
            char[] chars = words[i].ToCharArray();
            Array.Reverse(chars);
            words[i] = new string(chars);
        }
        string revString = string.Join(" ",words);
        Console.WriteLine(revString);
        //Console.WriteLine(revString.Length);
    }
}

