using System;

namespace Algorithm;

public class RemoveExtraSpaces
{
    public static void Run(){
        while(true){
            Console.Write("input string: ");
            String s = Console.ReadLine()!;
            String newStr = Remove(s);
            Console.WriteLine(newStr);
        }
    }

    //快慢指针
    //快针遍历集合
    //慢针收集需要的元素
    public static String Remove(String s){
        char[] array = s.ToArray();
        //i as the fast pointer
        int slow =0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] != ' '){
                if(slow!=0){
                    array[slow] = ' ';
                    slow++;
                }
                //from current char to next non-space char
                while(i<array.Length && array[i]!= ' ' ){
                    array[slow] = array[i];
                    slow++;
                    i++;
                }
            }
        }
        char[] newArray = new char[slow+1];
        for (int j = 0; j < slow; j++){
            newArray[j] = array[j];
        }
        return new string(newArray);
    }

}
