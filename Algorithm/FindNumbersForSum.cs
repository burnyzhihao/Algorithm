using System;

namespace Algorithm;

public class FindNumbersForSum
{
    public static void Run(){
        while(true){
        Console.Write("input array: ");
        int[] a = Console.ReadLine()!.Split(" ").Select(i=>int.Parse(i)).ToArray();
        Console.Write("input sum: ");
        int sum = int.Parse(Console.ReadLine()!);
        var indexes = FindForSum(a,sum);
        Console.WriteLine(indexes);
        }
    }
    public static (int,int) FindForSum(int[] input, int sum){
        Dictionary<int,int> dict = new Dictionary<int, int>();
        for (int i = 0; i < input.Length; i++)
        {
            int number = input[i];
            int pairValue = sum - number;
            if(dict.ContainsKey(pairValue)){
                return (i,dict[pairValue]);
            }else{
                dict.Add(input[i],i);
            }
        }
        return (0,0);
    }
}
