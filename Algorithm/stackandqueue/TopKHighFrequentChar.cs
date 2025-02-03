using System;

namespace Algorithm.stackandqueue;

public class TopKHighFrequentChar
{
    public static void Run(){
        while(true){
        Console.Write("input string: ");
        String s = Console.ReadLine()!;
        var r = TopK(s,3);
        Console.WriteLine(new String(r));
        }
    }
    public static char[]  TopK(String s, int k){
        char[] array = s.ToArray();
        Dictionary<char,int> map = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if(map.ContainsKey(array[i]))
                map[array[i]]++; 
             else map.Add(array[i],1);
        }

        PriorityQueue<char,int> queue = new(Comparer<int>.Create((a,b)=>b-a));
        for (int i = 0; i < map.Count; i++)
        {
            char key = map.ElementAt(i).Key;
            queue.Enqueue(key,map[key]);
            if(queue.Count>k){
                queue.Dequeue();
            }
        }
        char[] r = new char[k];
        int j=0;
        while(queue.Count>0){
            r[j++] = queue.Dequeue();
        }
        return r;
    }
}
