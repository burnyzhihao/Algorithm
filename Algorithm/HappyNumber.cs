using System;
using System.Collections;

namespace Algorithm;

public class HappyNumber
{
    public static void Run(){
        while(true){
            Console.Write("input number: ");
            int number = int.Parse(Console.ReadLine()!);
            Console.WriteLine(IsHappyNumber(number).ToString());
        }
    }
    public static Boolean IsHappyNumber(int number){
        HashSet<int> set = new HashSet<int>();
        while(true){
            number = GetSumSquart(number);
            if(number ==1) return true;
            else if(set.Contains(number)) return false;
            else{ 
                set.Add(number);

            }
        }
    }
    private static int GetSumSquart(int number){
        int sum = 0;
        while(number>0){
            sum += (number%10)*(number%10);
            number = number/10;
        }
        return sum;
    } 

}
