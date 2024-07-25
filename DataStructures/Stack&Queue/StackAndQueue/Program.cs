namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Stackd stack = new Stackd();   
            stack.push(1);
          
            stack.push(2);
        
            stack.push(3);
            stack.push(4);
            Console.WriteLine("the top of the Stack : "+stack.peek());

            Console.WriteLine("remove the top of the stack :"+stack.pop());
            stack.pop();
            Console.WriteLine(stack.peek());
            stack.pop();
            Console.WriteLine(stack.peek());
            Console.WriteLine("================== QUEUE========================");
            Queued q = new Queued();
             q.enqueue(1);
            q.enqueue(2);
            q.enqueue(3);   
            q.enqueue(4); 
            Console.WriteLine( q.peek()); //1  
            q.dequeue();
            Console.WriteLine(q.peek());//2
            q.dequeue();
            Console.WriteLine(q.peek());//3
        }
    }
}
