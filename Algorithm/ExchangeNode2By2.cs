using System;

namespace Algorithm;

public class ExchangeNode2By2
{
    public static void Run(){
        Node<String> node = Node<String>.StringLinkedListfromInput();
        Node<String> dummyhead = new Node<string>(null);
        dummyhead.Next = node;
        Node<String> current = dummyhead;
        while(current.Next!=null && current.Next.Next !=null){
            Node<String> first = current.Next;
            Node<String> second = first.Next;
            //exchange
            Node<String> temp =second.Next;
            current.Next = second;
            second.Next = first;
            first.Next=temp;
            current = first;
        }
        dummyhead.Next.Print();
    }

}
