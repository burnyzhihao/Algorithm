using System;

namespace Algorithm;

public class ReplaceNumberWithNumber
{
    public static String Replace(String input){
        char[] inputChar = input.ToArray();
        String replace = "number";
        var size = input.Count();
        //cal the new size  after replacement
        for (int i = 0; i < inputChar.Length; i++)
        {
            if(Char.IsDigit(inputChar[i]))  size = size + replace.Count() -1;
        }
        //init new string size
        char[] newStr = new char[size];
        //copy origin str to new string
        for (int i = 0; i < inputChar.Length; i++)
        {
            newStr[i] = inputChar[i];
        }
        //setup double pointer
        int left = inputChar.Length - 1;
        int right = newStr.Length - 1;
        //move str
        while(left>=0){
            if(Char.IsDigit(newStr[left])){
                newStr[right] = 'r';
                right --;
                newStr[right] = 'e';
                right --;
                newStr[right] = 'b';
                right --;
                newStr[right] = 'm';
                right --;
                newStr[right] = 'u';
                right --;
                newStr[right] = 'n';
                right --;
            }else{
                newStr[right] = newStr[left];
                right --;
            }
            left --;
        }
        return new string(newStr);
    }

    public static void Run(){
        while(true){
            Console.Write("input: ");
            String input = Console.ReadLine()!;
            String output = Replace(input);
            Console.WriteLine(output);
        }
    }

}
