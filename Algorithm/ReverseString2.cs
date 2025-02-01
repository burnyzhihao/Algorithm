using System;

namespace Algorithm;

public class ReverseString2
{
    public static void Run(){
        String s = "1234567890";
        char[] cs = s.ToCharArray();
        int k =4;
        for (int i = 0; i < cs.Length; i+=2*k)
        {
            int start = i;
            int end;
            if(cs.Length - i <k) end = cs.Length-1;
            else end = i+k-1;
            while(start < end){
                char temp = cs[start];
                cs[start] = cs[end];
                cs[end] = temp;
                start++;
                end--;
            }
        }
        for (int i = 0; i < cs.Length; i++)
        {
            Console.Write(cs[i]);
        }

    }
}
