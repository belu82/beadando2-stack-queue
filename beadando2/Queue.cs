using System;
using System.Collections.Generic;
using System.Text;

namespace beadando2
{
    class Queue<T>
    {

        int size;
        public Element<T> head;
        public Element<T> rear;
       
        public Queue()
        {
            this.head = this.rear = null;
            size = 0;
        }

        public void push(T data)
        {
            Element<T> temp = new Element<T>();

            if (temp == null)
            {
                return;
            }
            else
            {
                temp.Data = data;
                temp.Next = rear;               
                head = temp;
                rear = temp;
               
            }
            size++;
        }

        public T pop()
        {

            if (head == null)
            {
                throw new IndexOutOfRangeException();
            }

            T data = rear.Data;
            head = head.Next;

            return data;
        }

        private void print(Element<T> actualElement, StringBuilder stringBuilder)
        {
            if (actualElement == null)
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
