using System;

namespace Algorithm;

public class SpiralMatrix
{
    public static void Run(){
        Console.WriteLine("input n:");
        int n = int.Parse(Console.ReadLine()!);
        int[,] ma = new int[n,n];
        int startX =0; //row index
        int startY =0; //colum index
        int end =1; // end position for each line(column)
        //while loop control round
        //the number of round is n/2
        int r = 0;
        int current =0;
        while(r < n/2){
            //upper horizantal
            for(int i=startY;i<n-end;i++) ma[startX,i] = current++;
            //right vertical
            for(int i=startX;i<n-end;i++) ma[i,n-end] = current++;
            //bottom horizantal
            for(int i=n-end;i>startY;i--) ma[n-end,i] = current++;
            //vertical left
            for(int i =n-end; i>startX;i--) ma[i,startY] = current++;
            //deal with odd number
            if(n % 2 == 1) ma[n/2,n/2] = current++;
            r++;
            startX++;
            startY++;
            end++;
        }

        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                Console.Write(ma[i,j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    

}
