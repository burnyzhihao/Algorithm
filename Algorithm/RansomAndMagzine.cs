using System;

namespace Algorithm;

public class RansomAndMagzine
{
    public static bool IsFit(String ransomStr, String magzineStr){
        //put magzie letters into the letter-dic array
        int[] magzie = new int[26];
        for (int i = 0; i < magzineStr.Length; i++)
        {
            magzie[magzineStr[i] - 'a'] ++;
        }
        //check ransom letters are in magzine or not
        for (int i = 0; i < ransomStr.Length; i++)
        {
            if(magzie[ransomStr[i] - 'a'] > 0){
                magzie[ransomStr[i] - 'a'] --;
            }else{
                return false;
            }
        }
        return true;

    }

    public static void Run(){
        while(true){
            Console.Write("input ransom:");
            string ransom = Console.ReadLine()!;
            Console.Write("input magzine:");
            string magzine = Console.ReadLine()!;
            Console.WriteLine(IsFit(ransom,magzine));
        }
    }
}
