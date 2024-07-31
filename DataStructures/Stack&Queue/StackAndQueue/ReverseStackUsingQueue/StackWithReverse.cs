using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.ReverseStackUsingQueue
{
    public class StackWithReverse : Stackd
    {

        public void ReverseStack()
        {
            if (isEmpty() || top.Next ==null )
            {
             
                return;
            }

            
            Queued queue = new Queued();

            
            while (!isEmpty())
            {
                queue.enqueue(pop());
            }

            
            while (!queue.isEmpty())
            {
                push(queue.dequeue());
            }
        }
    
}
}
