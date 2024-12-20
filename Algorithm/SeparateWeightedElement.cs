using System;

namespace Algorithm;

public class SeparateWeightedElement
{
    public static void Run(){
        Console.WriteLine("input:");
        int n  = int.Parse(Console.ReadLine()!);
        int m = int.Parse(Console.ReadLine()!);
        int[,] ma = new int[n,m];
        int sum = 0;
        for(int i =0;i<n; i++){
            for(int j=0;j<m;j++){
                ma[i,j] = int.Parse(Console.ReadLine()!);
                sum += ma[i,j];
            }
        }
        Console.WriteLine("input done");
        int result = int.MaxValue;
        int weightSum = 0;
        //separate horizatally
         for(int i =0;i<n; i++){
            for(int j=0;j<m;j++){
                weightSum += ma[i,j];
                if(j == m -1){
                    result = Math.Min(result, Math.Abs(weightSum - (sum - weightSum)));
                }
            }
        }
        weightSum =0;
        //separate vertically
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                weightSum+=ma[j,i];
                if(j == n-1){
                    result = Math.Min(result, Math.Abs(weightSum - (sum - weightSum)));
                }
            }
        }
        Console.WriteLine("result: "+ result);
    }

}
