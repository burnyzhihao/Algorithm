using System;

namespace Algorithm.stackandqueue;

public class ReversePolandExpression
{
    public static void Run(){
        String[] a =  ["2", "1", "+", "3", "*"];
        Console.WriteLine(execute(a));
        a =   ["4", "13", "5", "/", "+"];
        Console.WriteLine(execute(a));
        a =  ["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"];
        Console.WriteLine(execute(a));
    }

    public static String execute(String[] expression){

        Stack<String> stack = new Stack<String>();
        String[] op = new String[]{"+","-","*","/"};
        for (int i = 0; i < expression.Length; i++)
        {
            if(op.Contains(expression[i])){
                var num1 = stack.Pop();
                var num2 = stack.Pop();
                stack.Push(calculate(num1,num2,expression[i]));
            }else{
                stack.Push(expression[i]);
            }
        }
        return stack.Pop();
    }
    private static String calculate(String n1,String n2, String op){
        switch(op){
            case "+" : return (int.Parse(n1) + int.Parse(n2)).ToString();
            case "-" : return (int.Parse(n2) - int.Parse(n1)).ToString();
            case "*" : return (int.Parse(n1) * int.Parse(n2)).ToString();
            case "/" : return (int.Parse(n2) / int.Parse(n1)).ToString();
        }
        return "0";
    }

}
