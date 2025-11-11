using System;
using System.Linq;
public class HelloWorld
{
    public static void Main(string[] args)
    {
       int[] array = new int[] {1,2,3,1,3};
       var result = array.GroupBy(n=> n).Where(g => g.Count()>1).Select(g=> g.Key);
       
       Console.WriteLine(string.Join(',',result));
    }
}
