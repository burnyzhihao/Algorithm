using System;

namespace Algorithm;

public class RemoveFromLinkedList
{
    public static void Run(){
        Node<String> head = Node<String>.StringLinkedListfromInput();
        Node<String> dummyHead = new Node<string>("null");
        dummyHead.Next = head;
        Node<String> currentNode = dummyHead;
        Console.Write("remove: ");
        String sr = Console.ReadLine()!;
        while(currentNode.Next!=null){
            if(currentNode.Next.Data ==sr){
                currentNode.Next = currentNode.Next.Next;
            }else{
                currentNode = currentNode.Next;
            }
        }
        dummyHead.Next.Print();
    }
}
