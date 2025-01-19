using System;

namespace Algorithm;

public class SumOfThreeElements
{
    public static void Run(){
        //get the combination of 3 elemnts whose sum is 0, no duplication
        int[] elements =  [-1, 0, 1, 2, -1, -4];
        int[] sortedEle = elements.AsQueryable().Order().ToArray();
        for (int i = 0; i < sortedEle.Length; i++){
            if(sortedEle[i]>0) continue; //not possible to 0 as the first one >0

            if(i>0 && sortedEle[i] ==sortedEle[i-1]) continue; //skip duplication for 1st ele

            int left = i+1;
            int right = sortedEle.Length - 1;
            // determine the 2nd and 3rd number
            while(right>left){
                if(sortedEle[i] + sortedEle[left] + sortedEle[right] >0){
                    //sum is too big, move the right
                    right --;
                }
                else if(sortedEle[i] + sortedEle[left] + sortedEle[right] <0){
                    //sum is too small, move the left
                    left ++;
                }
                else{
                    //find the result
                    Console.WriteLine(sortedEle[i]+" "+sortedEle[left]+" "+sortedEle[right]);
                    //skip duplication of 2nd number
                    while(right>left && sortedEle[left+1]==sortedEle[left]) left ++;
                    //skip duplication of 2nd number
                    while(right>left && sortedEle[right-1]==sortedEle[right]) right --;
                    //reduce the sop
                    right--;
                    left--;
                }
                

            }
            
        }
        {
            
        }
    }

}
