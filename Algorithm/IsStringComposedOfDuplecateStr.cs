using System;

namespace Algorithm;

public class IsStringComposedOfDuplecateStr
{
    public static void Run(){
        while(true){
        Console.Write("input string: ");
        String s = Console.ReadLine()!;
        bool r = IsStrComponsedOfStr(s);
        Console.WriteLine(r);
        }
    }
    public static bool IsStrComponsedOfStr(String s){
        if (s.Length == 0) return false;
        int strLenth = s.Length;
        int[] next = FindStrInStr_kmp.GetNextArray(s);
        if(next[next.Length-1] !=0 && strLenth % (strLenth - next[next.Length-1])==0){
            return true;
        }
        return false;

    }

}
