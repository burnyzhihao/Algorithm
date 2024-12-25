using System;

namespace Algorithm;

public class RmoveFromReverse
{
    public static void Run(){
        Node<String> node = Node<String>.StringLinkedListfromInput();
        Console.Write("remove frome reverse No. : ");
        int n = int.Parse(Console.ReadLine()!);
        Node<String> dummyhead = new Node<string>(null);
        dummyhead.Next = node;
        Node<String> fast = node;
        Node<String> slow = node;

        for(int i=0;i<n;i++) fast = fast.Next;

        while(fast.Next !=null){
            fast = fast.Next;
            slow = slow.Next;
        }
        slow.Next = slow.Next.Next;
        dummyhead.Next.Print();
        
    }

}
