using System;

namespace Algorithm;

public class FindIntersectionOfArray
{
    
    public static void Run(){
        int[] a =[1,3,5,3,6,7,15,12,14];
        int[] b =[2,3,5,7,12,18];
        int[] result = findIntersection(a,b);
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]+" ");
        }
        
    }

    private static int[] findIntersection(int[] array1, int[] array2){
        HashSet<int> setA = new HashSet<int>(array1); 
        HashSet<int> setB = new HashSet<int>(array2);
        var result = setA.Intersect(setB);
        return result.ToArray();
    }
}
