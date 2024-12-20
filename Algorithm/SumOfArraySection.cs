using System;

namespace Algorithm;
//区间求和
public class SumOfArraySection
{
    public static void Run(){
        Console.WriteLine("input:");
        String? num = Console.ReadLine();
        int arrayNum = int.Parse(num!);
        int[] arraySum = new int[arrayNum];
        int[] prefixSum = new int[arrayNum];
        int preSum = 0;
        for(int i=0;i<arrayNum;i++){
            string[] input = (Console.ReadLine()!).Split(' ');
            arraySum[i] = input.Sum(s=>int.Parse(s));
            preSum += arraySum[i]; 
            prefixSum[i] =preSum;
        }
        Console.WriteLine("input question:");
        String[] inputq = (Console.ReadLine()!).Split(' ');
        int start = int.Parse(inputq[0]);
        int end = int.Parse(inputq[1]);
        int sum;
        sum = start == 0? prefixSum[end] : prefixSum[end] - prefixSum[start-1];

        Console.WriteLine("anwser is: "+ sum.ToString());
        
    }


}
