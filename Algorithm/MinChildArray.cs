using System;
using System.ComponentModel.DataAnnotations;

namespace Algorithm;
//和大于制定值的最小长度子串
public class MinChildArray
{

    private static int FindMinChildArray(int[] data, int value){
        //外层for循环控制终止位置
        //内层 while 控制开始位置
        int index_start = 0;
        int sum = 0;
        int minlengh = data.Length;
        for(int i =0; i< data.Length; i++){
            int index_end = i;
            sum += data[index_end];
            while(sum >= value){
                int tempLengh = index_end - index_start + 1;
                minlengh = minlengh<tempLengh? minlengh:tempLengh;
                sum-=data[index_start];
                index_start++;
                
            }
        }
        return minlengh;
    }

    public static void Run(){
        int[] data = [2,3,1,2,4,3];
        int minlen = FindMinChildArray(data, 7);
        Console.Write(minlen);

    }

}
