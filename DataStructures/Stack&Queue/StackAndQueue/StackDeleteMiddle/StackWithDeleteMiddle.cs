using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.StackDeleteMiddle
{
    public class StackWithDeleteMiddle:Stackd
    {
        public void DeleteMiddle()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            
            int size = GetSize();
            int middle = size / 2;
            if (size % 2 == 0) middle--;

          
            Stackd tempStack = new Stackd();

          
            for (int i = 0; i < middle; i++)
            {
                tempStack.push(pop());
            }

        
            pop();

            while (!tempStack.isEmpty())
            {
                push(tempStack.pop());
            }
        }

        private int GetSize()
        {
            int size = 0;
            Node current = top;
            while (current != null)
            {
                size++;
                current = current.Next;
            }
            return size;
        }
    }
}
