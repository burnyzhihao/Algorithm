using System;

namespace Algorithm.stackandqueue;

public class StackByQueue
{
    public static void Run(){
        MyStack<int> stack = new MyStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        Console.WriteLine(stack.Pop());//4
        Console.WriteLine(stack.Pop());//3
        Console.WriteLine(stack.Top());//2
        Console.WriteLine(stack.Pop());//2

    }
    public class MyStack<T>{
        private Queue<T> queue = new Queue<T>();
        public void Push(T element){
            this.queue.Enqueue(element);
        }
        public  T Pop(){
            for (int i = 0; i < queue.Count - 1; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            return  queue.Dequeue();
        }

        public bool IsEmpty(){
            return this.queue.Count()==0;
        }

        public T Top(){
             for (int i = 0; i < queue.Count - 1; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            var r = queue.Dequeue();
            this.queue.Enqueue(r);
            return r;
        }
    }

}
