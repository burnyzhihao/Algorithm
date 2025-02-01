using System;

namespace Algorithm;

public class RightRotateString
{
    //右旋字符串给定位数
    public static String RightRotate(String s, int number){
        //1. reverse the whole string
        s = ReverseString.Reverse(s,0,s.Length-1);
        //2. reverse the two part of string sepparately
        s = ReverseString.Reverse(s,0,number-1);
        s = ReverseString.Reverse(s,number,s.Length-1);
        return s;
    }

    public static void Run(){
         while(true){
            Console.Write("input string: ");
            String s = Console.ReadLine()!;
            Console.Write("input number to rotate: ");
            String n = Console.ReadLine()!;
            String newStr = RightRotate(s,int.Parse(n));
            Console.WriteLine(newStr);
        }
    }
}
