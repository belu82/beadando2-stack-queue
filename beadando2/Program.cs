using System;

namespace beadando2
{
    class Program
    {
     
        static void Main(string[] args)
        {
            /*
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddToEnd(1);
            linkedList.AddToEnd(2);

            Console.WriteLine(linkedList.ToString());

            linkedList.addToIndex(2, 2);
            linkedList.addToIndex(12, 0);

            Console.WriteLine(linkedList.ToString());

            linkedList.deleteByIndex(0);

            Console.WriteLine(linkedList.ToString());

            linkedList.deleteAll();
            Console.WriteLine(linkedList.ToString());
            */
            

            Stack<int> stack = new Stack<int>();
            stack.push(22);
            stack.push(33);
            stack.push(44);

            Console.WriteLine(stack.ToString());

            stack.pop();
            stack.pop();

            Console.WriteLine(stack.ToString());
            

            Queue<int> queue = new Queue<int>();
            queue.push(12);
            queue.push(11);
            queue.push(10);
            queue.push(9);
            Console.WriteLine(queue.ToString());

            queue.pop();

            Console.WriteLine(queue.ToString());

        }
    }
}
