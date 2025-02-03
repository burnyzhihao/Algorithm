using System;

namespace Algorithm.stackandqueue;

public class RemoveNeighboringDuplicateChar
{
    public static void Run(){
        while(true){
        Console.Write("input string: ");
        String s = Console.ReadLine()!;
        String r = Remove(s);
        Console.WriteLine(r);
        }
    }
    public static String Remove(String s){
        char[] array = s.ToArray();
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < array.Length; i++)
        {
            if(stack.Count==0 || stack.Peek()!=array[i]){
                stack.Push(array[i]);
            }else{
                stack.Pop();
            }
        }
        String r = string.Empty;
        while(stack.Count>0){
            r = stack.Pop().ToString() + r;
        }
        return r;
    }

}
