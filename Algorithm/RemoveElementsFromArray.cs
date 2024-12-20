using System;

namespace Algorithm;
//从数组中移除制定元素，不适用额外空间
public class RemoveElementsFromArray
{
    public static int DoublePointer(int[] data, int target){
        int index_fast = 0, index_slow = 0;
        while(index_fast < data.Count()){
            if(data[index_fast] != target){
                data[index_slow] = data[index_fast];
                index_fast++;
                index_slow++;
            }else{
                index_fast++;
            }
            
        }
        return index_slow;
    }
    public static void Run(){
        int[] data = [0,1,2,2,3,0,4,2];
        int r = DoublePointer(data ,2);
        Console.WriteLine(r);
        for(int i=0;i<r;i++){
            Console.WriteLine(data[i]);
        }
    }
}
