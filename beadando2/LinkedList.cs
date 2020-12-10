using System;
using System.Collections.Generic;
using System.Text;

namespace beadando2
{
    class LinkedList<T>
    {

        Element<T> head;
        int size;

        public LinkedList()
        {
            head = new Element<T>();
            size = 0;
        }

        internal Element<T> Head { get => head; set => head = value; }

        public void AddToEnd(T data)
        {
            if(size == 0)
            {
                head.Data = data;
            }
            else
            {
                searchAndAdd(head, data);
            }

            size++;
        }

        private void searchAndAdd(Element<T> actualElement, T value)
        {
            if(actualElement.Next == null)
            {
                Element<T> newElement = new Element<T>();
                newElement.Data = value;
                actualElement.Next = newElement;
                size++;
            }
            else
            {
                searchAndAdd(actualElement.Next, value);
            }
        }


        public void addToIndex(T value, int index)
        {
            if(index > size)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                searchAndAddIndex(head, value, index, 0);
            }
        }

        private void searchAndAddIndex(Element<T> actualElement, T value, int index, int i)
        {
            if (i == index - 1)
            {
                Element<T> newElement = new Element<T>();
                newElement.Data = value;
                newElement.Next = actualElement.Next;
                actualElement.Next = newElement;
                size++;
            }
            else if (index == 0)
            {
                Element<T> newELement = new Element<T>();
                newELement.Data = value;
                newELement.Next = head;
                Head = newELement;
                size++;
            }
            else
            {
                searchAndAddIndex(actualElement.Next, value, index, i + 1);
            }
        }

        public T deleteByIndex(int index)
        {
            if(size == 1)
            {
                T value = head.Data;
                head = new Element<T>();
                size--;
                return value;
            }
            else
            {
                return searchAndDelete(Head, index, 0);
            }
        }

        private T searchAndDelete(Element<T> actElement, int index, int i)
        {
            if(index == 0)
            {
                T value = Head.Data;
                Head = Head.Next;
                size--;
                return value;
            }else if(i == index - 1)
            {
                T value = actElement.Next.Data;
                actElement.Next = actElement.Next.Next;
                size--;
                return value;
            }
            else
            {
                return searchAndDelete(actElement.Next, index, i + 1);
            }
        }

        public void deleteAll()
        {
            head = new Element<T>();
            size = 0;
        }
        private void print(Element<T> actualElement, StringBuilder stringBuilder)
        {
            stringBuilder.Append(actualElement.Data).Append(", ");
            if(actualElement.Next != null)
            {
                print(actualElement.Next, stringBuilder);
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
