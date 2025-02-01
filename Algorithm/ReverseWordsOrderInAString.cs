using System;

namespace Algorithm;

public class ReverseWordsOrderInAString
{
    //倒转一个字符串中所有单子的顺序，并去掉多余的空格（单词间保留一个空格）
    public static String Reverse(String s){
        //step1 remove extra spaces
        s = RemoveExtraSpaces.Remove(s);
        //step2 reverse the all chars
        s = ReverseString.Reverse(s,0,s.Length-1);
        //step3 reverse every word
        char[] array = s.ToArray();
        int start =0;
        for (int i = 0; i < array.Length; i++)
        {
            while(i<array.Length && array[i]!=' ') i++;
            //revese the word
            int left =start, right = i-1;
            while(left<right){
                char temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                left++;
                right--;
            }
            //skip the next space
            i++;
            start = i;

        }
        return new string(array);
    }

    public static void Run(){
         while(true){
            Console.Write("input string: ");
            String s = Console.ReadLine()!;
            String newStr = Reverse(s);
            Console.WriteLine(newStr);
        }
    }

}
