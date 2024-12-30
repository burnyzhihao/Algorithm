using System;

namespace Algorithm;

public class FindCommonLetters
{
    public static void Run(){
        String[] input = {"accdeeeghh","aceeh","aacceeghhh"};
        var result = FindCommon(input);
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]+" ");
        }
        
    }

    public static String[] FindCommon(String[] strings){
        //indexing the first string
        int[] firstStr = new int[26];
        for (int i = 0; i < strings[0].Length; i++)
        {
            int charIndex = strings[0][i] - 'a';
            //char occorence +1
            firstStr[charIndex]++;
        }
        //deal with other strings and cal common

        for (int i = 1; i < strings.Length; i++)
        {
            //indexing other string one by one
            int[] otherStr = new int[26];
            for (int j = 0; j < strings[i].Length; j++)
            {
                int charIndex = strings[i][j] - 'a';
                otherStr[charIndex] ++;
            }
            //calculate common char against first string
            for (int z = 0; z < firstStr.Length; z++)
            {
                firstStr[z] = Math.Min(firstStr[z], otherStr[z]);
            }
        }
        //format output strings
        int commonCharCount=0;
        for (int j = 0; j < firstStr.Length; j++)
        {
            commonCharCount = commonCharCount + firstStr[j];
        }
        String[] result = new string[commonCharCount];
        int initIndex =0;
        for (int i = 0; i < firstStr.Length; i++)
        {
            for (int z = 0; z < firstStr[i]; z++)
            {
                result[initIndex++] = ((char)(i + 'a')).ToString();
            }
        }
        return result;
    }

}
