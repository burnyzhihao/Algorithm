using System;

namespace Algorithm.stackandqueue;

public class QueueByStacks
{
    public static void Run(){
        MyQueue<int> queue = new MyQueue<int>();
        queue.Push(1);
        queue.Push(2);
        queue.Push(3);
        queue.Push(4);
        Console.WriteLine(queue.pop()); //1
        Console.WriteLine(queue.pop());//2
        queue.peek();//3
        queue.Push(5);
        Console.WriteLine(queue.pop()); //3
        Console.WriteLine(queue.pop());//4

    }
    public class MyQueue<T>{
        private Stack<T> inStack = new Stack<T>();
        private Stack<T> outStack = new Stack<T>();

        public T peek(){
            T element = this.outStack.Pop();
            this.outStack.Push(element);
            return element;
        }
        public void Push(T element){
            this.inStack.Push(element);
        }
        public bool IsEmpty(){
            return inStack.Count()==0 && outStack.Count==0;
        }
        public T  pop(){
            if(outStack.Count()==0){
                PutAllInstackToOutStack();

            }
            return outStack.Pop();
        }
        private void PutAllInstackToOutStack(){
            while(inStack.Count()>0){
                outStack.Push(inStack.Pop());
            }
        }
    }

}
