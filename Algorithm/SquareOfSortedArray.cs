using System;

namespace Algorithm;
//有序数组的平方，结果仍然有序
public class SquareOfSortedArray
{
    public static void Run(){
        int[] data = [-4,-1,0,3,10];
        int[] result = Sort(data);
        result.ToList().ForEach(i=>Console.Write(i.ToString()+" "));
        Console.WriteLine();
        data = [-7,-3,2,3,11];
        result = Sort(data);
        result.ToList().ForEach(i=>Console.Write(i.ToString()+" "));

    }

    public static int[] Sort(int[] data){
        int[] result = new int[data.Length];
        int index_left = 0, index_right = data.Length-1, index_new = data.Length-1;

        while(index_left != index_right){
            if(data[index_left] * data[index_left] <= data[index_right] * data[index_right]){
                result[index_new] = data[index_right]*data[index_right];
                index_new --;
                index_right --;               
            }else{
                result[index_new] = data[index_left]*data[index_left];
                index_new --; 
                index_left ++;
            }
        }
        result[0] = data[index_left];
        return result;

    }

}
