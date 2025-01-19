using System;

namespace Algorithm;

public class SumOf4ElemsFrom4Array
{
    public static void Run()
    {
        int[] a = [1, 2];
        int[] b = [-2, -1];
        int[] c = [-1, 2];
        int[] d = [0, 2];

        Dictionary<int,int> sumOfab = new Dictionary<int, int>();
        //calculate the sum of elements from a and b. 
        //and the occurance of the sum
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                int sum = a[i] + b[j];
                if(sumOfab.ContainsKey(sum)){
                    sumOfab[sum] = sumOfab[sum] + 1;
                }else{
                    sumOfab.Add(sum,1);
                }
            }
        }
        int count = 0;
        //calulate the sum of elemnts from c and d
        //try to find the needed differnce from hash
        for (int i = 0; i < c.Length; i++)
        {
            for (int j = 0; j < d.Length; j++)
            {
                int sum = c[i] + d[j];
                if(sumOfab.ContainsKey(0-sum) && sumOfab[0-sum]>0){
                    count ++;
                    sumOfab[0-sum] --;
                }
            }
        }
        Console.WriteLine(count);
    }
}
