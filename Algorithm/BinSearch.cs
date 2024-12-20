using System;

namespace Algorithm;
//二分查找
public class BinSearch
{
    public static void run(){
        Console.WriteLine(search([-1,0,3,5,9,12],9));
        Console.WriteLine(search([-1,0,3,5,9,12],2));
    }

    public static int search(int[] data, int target){

        if (data.Count()==0) return -1;
        int index_left = 0;
        int index_right = data.Count() - 1;
        while (index_left <= index_right)
        {
            int middle = (index_left + index_right)/2;
            if(data[middle] == target) return middle;
            if(data[middle] > target) index_right = middle -1;
            if(data[middle] <target) index_left = middle + 1;
        }
        return -1;
    }
}
