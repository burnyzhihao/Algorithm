using System;

namespace Algorithm;

public class Node<T>(T data)
{
    public T Data { get; set; } = data;

    public Node<T>? Next { get; set; } = null;

    public static Node<String> StringLinkedListfromInput(){
        Console.Write("input: ");
        String[] list = Console.ReadLine()!.Split(" ");
        Node<String> head = null;
        Node<String> current = head;
        foreach(String s in list){
            if(current ==null) {
                current = new Node<string>(s);
                head = current;
            }
            else{
                current.Next=new Node<string>(s);
                current = current.Next;
            }                       
        }
        return head;
    }

    public void Print(){
        var node = this;
        while(node!=null){
            Console.Write(node.Data.ToString());
            Console.Write(" ");
            node = node.Next;
        }
        Console.WriteLine();
    } 
    public Node<T> Inverse(){
        Node<T> pre=null;
        Node<T> cur = this;
        while(cur!=null){
            Node<T> temp = cur.Next;
            cur.Next = pre;
            pre = cur;
            cur = temp;
        }
        return pre;
    }
    public int Length(){
        int len = 0;
        var node = this;
        while(node!=null){
            len++;
            node = node.Next;
        }
        return len;
    }
}
