using System;

namespace Algorithm;

public class FindIntersection
{
    public static void Run(){
        Node<String> linkA=null ,linkB =null;
        Node<String> curA=null;
        for(int i=0;i<5;i++){
            if(linkA==null){
                linkA = new Node<string>(i.ToString());
                curA = linkA;
            }else{
                curA.Next = new Node<string>(i.ToString());
                curA = curA.Next;
            }
        }
        Node<String> curB=null;
        for(int i=0;i<7;i++){
            if(linkB==null){
                linkB = new Node<string>(i.ToString());
                curB = linkB;
            }else{
                curB.Next = new Node<string>(i.ToString());
                curB = curB.Next;
            }
        }

        Node<String> node = Node<String>.StringLinkedListfromInput();
        curA.Next = node;
        curB.Next = node;
        linkA.Print();
        linkB.Print();
        //find intersection
        int lenA = linkA.Length();   
        int lenB = linkB.Length();   
  
        if(lenA>lenB)
        {
            for(int i=0;i<lenA-lenB;i++){
                linkA = linkA.Next;
            }
        }else
        {
                for(int i=0;i<lenB-lenA;i++){
                linkB = linkB.Next;
        }
        while(linkA!=null){
            if(linkA==linkB){
                Console.WriteLine("Intersection at "+linkA.Data);
                break;
            }
            linkA = linkA.Next;
            linkB = linkB.Next;
        }
    }
    }
}
