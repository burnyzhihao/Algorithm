using System;

namespace Algorithm;

public class ArePossitionDiffWords
{
    public static void Run(){
        Console.Write("input word1: ");
        String word1 = Console.ReadLine()!;
        Console.Write("input word2: ");
        String word2 = Console.ReadLine()!;
        Console.WriteLine(ArePosstionDiff(word1,word2).ToString());
    }
    public static bool ArePosstionDiff(String word1,String word2){
        int[] map = new int[26];
        for(int i=0;i<word1.Length;i++){
            int mapIndex = word1[i] - 'a';
            map[mapIndex]++;
        }
        for(int i=0;i<word2.Length;i++){
            int mapIndex = word2[i] - 'a';
            map[mapIndex]--;
        }
        for(int i=0;i<map.Length;i++){
            if(map[i]!=0) return false;
        }
        return true;
    }

}
