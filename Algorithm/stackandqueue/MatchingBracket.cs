using System;

namespace Algorithm.stackandqueue;

public class MatchingBracket
{
    public static void Run(){
        while(true){
        Console.Write("input string: ");
        String s = Console.ReadLine()!;
        bool r = IsMatch(s);
        Console.WriteLine(r);
        }
    }
    public static bool IsMatch(String s){
        Dictionary<char,char> map = new Dictionary<char, char>();
        map.Add('(',')');
        map.Add('[',']');
        map.Add('{','}');
        Stack<char> stack=new Stack<char>();
        for (int i = 0; i < s.ToArray().Length; i++)
        {
            //if it's left, then push right
            if(map.Keys.Contains(s[i])){
                stack.Push(map[s[i]]);
            } // it's right, then match top of stack
            else if(stack.Count>0){
                if(s[i] == stack.Pop()) continue; //match
                else return false;
            }//stack is empty
            else{
                return false;
            }
        }
        if(stack.Count==0) return true;
        else return false;
    }

}
