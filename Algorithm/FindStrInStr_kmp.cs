using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Algorithm;

public class FindStrInStr_kmp
{
    public static int[] GetNextArray(String s){
        char[] arrayChar = s.ToArray();
        //init
        int[] next = new int[s.Length];
        //first element is always 0
        next[0] = 0;
        //j points to the end of prefix
        int j = 0;
        //i points to the end of sufix
        for (int i = 1; i < arrayChar.Length; i++)
        {
            //when prefix is not equal to sufix
            while(arrayChar[i] != arrayChar[j] && j>0){
                j = next[j-1];
            }
            //when prefix is equal to sufix
            if(arrayChar[i] == arrayChar[j]){
                j++;
            }
            //set element of next array
            next[i] = j;   
        }
        return next;
    }
    public static int FindStringInStr(String s, String str){
        int[] next = GetNextArray(str);
        char[] input = s.ToArray();
        char[] pattern = str.ToArray();
        int j = 0; // j is the pointer to pattern
        //i is the pointer of input string
        for (int i = 0; i < input.Length; i++)
        {
            //not match, move backward
            while(input[i] != pattern[j] && j>0){
                j = next[j-1];
            }

            //match one char
            if(input[i] == pattern[j]){
                j++;
            }
            //match the pattern
            if(j==pattern.Length){
                return i-pattern.Length+1;
            }
        }
        return -1;

    }

    public static void Run(){
         while(true){
            Console.Write("input string: ");
            String input = Console.ReadLine()!;
            Console.Write("input pattern str: ");
            String s = Console.ReadLine()!;
            Console.Write("next array: ");
            int[] next = GetNextArray(s);
            Console.WriteLine(next.Select(x=>x.ToString()).Aggregate((s,c)=> s + c));
            int r = FindStringInStr(input,s);
            Console.WriteLine(r);

        }
    }
}
