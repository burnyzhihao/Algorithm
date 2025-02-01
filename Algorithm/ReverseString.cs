using System;

namespace Algorithm;

public class ReverseString
{
    public static void Run(){
       while(true){
        Console.Write("input string: ");
        String s = Console.ReadLine()!;
        String reversedStr = Reverse(s,0,s.Length-1);
        Console.WriteLine(reversedStr);
       }
    }
    public static String Reverse(String s, int start, int end){
        char[] cs = s.ToCharArray();
        while(start<end){
            char temp = cs[start];
            cs[start] = cs[end];
            cs[end] = temp;
            start++;
            end--;
        }
        return new string(cs);
    }
}
