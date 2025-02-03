using System;
using System.Diagnostics;

namespace Algorithm.stackandqueue;

public class MaxValueInSidingWindow
{
    public static void Run(){
        int[] nums = [1,3,-1,-3,5,3,6,7];
        var result = MaxValue(nums,3);
        Console.WriteLine(result.Select(x=>x.ToString()).Aggregate((a,b)=>a+b));
    }

    //固定长度K窗口从一个字符串从左向右滑动，一次一个字符，求每次滑动窗口中的最大值
    
    public static  int[] MaxValue(int[] array, int k ){
        int[] result = new int[array.Length - k +1];
        //定义双向队列作为滑动窗口
        IntMonoque intMonoque = new IntMonoque();
        //入队前k个元素
        for (int i = 0; i < k; i++)
        {
            intMonoque.Enqueue(array[i]);           
        }
        //滑动计算
        int j =k;
        int r =0;
        while(j<array.Length){
            //取最大值
            result[r] = intMonoque.GetMaxValue();
            //滑动
            intMonoque.Dequeue(array[r++]);
            intMonoque.Enqueue(array[j++]);
        }
        result[r] = intMonoque.GetMaxValue();
        return result;
    }

    //实现一个单调队列用于滑动窗口
    public class IntMonoque{
        private LinkedList<int> queue = new LinkedList<int>();

        public void Enqueue(int element){
            //如果队尾元素小于待入队元素，从队尾出队
            while(queue.Count>0 && queue.Last!.Value < element){
                queue.RemoveLast();
            }
            this.queue.AddLast(element);
        }

        public void Dequeue(int value){
            //如果队首元素就是给定元素，从队首出队
            if(this.queue.First!.Value ==value){
                this.queue.RemoveFirst();
            }
        }
        public int GetMaxValue(){
            //队首就是最大元素
            return this.queue.First!.Value;
        }
    }
}
