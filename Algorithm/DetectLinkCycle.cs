using System;

namespace Algorithm;

public class DetectLinkCycle
{

    public static void Run(){
        //create cycle
        Node<String> node = Node<String>.StringLinkedListfromInput();
        Console.Write("input cycle start position: ");
        int cycleStart = int.Parse(Console.ReadLine());
        var curr = node;
        for(int i=0;i<cycleStart;i++){
            curr =curr.Next;
        }
        var end = node;
        while(end.Next!=null){
            end = end.Next;
        }
        end.Next = curr;

        Console.WriteLine(FindLinkCycle(node));
    }

    public static int FindLinkCycle(Node<String> node){
        Node<string> fast = node;
        Node<String> slow = node;
        while(fast.Next.Next!=null){
            fast = fast.Next.Next;
            slow = slow.Next;
            if(fast==slow){
                //find cycle
                Node<String> first = node;
                Node<String> second = fast;
                int count = 0;
                while(first!=second){
                    count++;
                    first = first.Next;
                    second = second.Next;
                }
                return count;
            }
        }
        return -1;

    }

}
