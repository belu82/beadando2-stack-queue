using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace beadando2
{
    class Stack<T>
    {
        Element<T> head;

        internal Element<T> Head { get => head; set => head = value; }
      

       
        public Stack()
        {
            this.head = null;
        }
        public void push(T data)
        {
            Element<T> temp = new Element<T>();

            if(temp == null)
            {
                return;
            }
            else
            {
                temp.Data = data;
                temp.Next = head;
                head = temp;


            }
        }

        public void pop() 
        {
 
            if (head == null)
            {
                throw new IndexOutOfRangeException();
            }


            head = (head).Next;
        }

        private void print(Element<T> actualElement, StringBuilder stringBuilder)
        {
            if(actualElement == null)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }
            else
            {
                stringBuilder.Append(actualElement.Data).Append(", ");
                if (actualElement.Next != null)
                {
                    print(actualElement.Next, stringBuilder);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            print(head, stringBuilder);
            return stringBuilder.ToString();
        }
    }
}
