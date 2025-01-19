using System;
using System.Runtime;

namespace Algorithm;

public class SumOfFourNumberToSpecifiedValue
{
    public static void Run(){
        int[]  nums = [1, 0, -1, 0, -2, 2];
        int target = 1;
        //sort the nums
        nums = nums.AsQueryable().Order().ToArray();
        //deal with first element k
        for (int k = 0; k < nums.Length-2; k++)
        {
            //reduce impossible 
            if(nums[k]>0 && target>0 && nums[k] > target) continue;
            //remove duplicate for k
            if(k>0 && nums[k] == nums[k-1]) continue;
            //deal with the 2nd element
            for (int i=k+1; i < nums.Length-2; i++)
            {
                //reduce impossible
                if((nums[k] + nums[i]>0)&& target>0 && nums[k] + nums[i]>target) continue;
                //remove duplicate for i
                if(i>(k+1)&&nums[i] ==nums[i-1]) continue;

                int left = i+1;
                int right = nums.Length-1;
                //deal with the last 2 elements
                while(right>left){
                    if(nums[i]+nums[k]+nums[left]+nums[right]>target){right--;} 
                    else if(nums[i]+nums[k]+nums[left]+nums[right]<target){left++;} 
                    else{
                        //find the combination
                        Console.WriteLine(nums[i] +" "+ nums[k] +" "+nums[left] +" "+nums[right]);
                        //remove duplicate for left
                        while(right>left && nums[left] == nums[left+1]) left++;
                        //remove duplicate for rifht
                        while(right>left && nums[right] ==nums[right-1]) right--;
                        left++;
                        right--; 
                    }


                }
                
            }
        }
    }

}
