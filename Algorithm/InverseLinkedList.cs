using System;

namespace Algorithm;

public class InverseLinkedList
{
    public static void Run(){
        Node<String> node = Node<String>.StringLinkedListfromInput();
        node.Inverse().Print();
    }

}
