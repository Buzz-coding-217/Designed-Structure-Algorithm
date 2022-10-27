using System;
using System.Collections.Generic;

namespace Stack
{
    //creating a class 'Stack'
    class Stack
    {
        // Creating Nodes which are present in the Stack
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }
        // Creating instance variable for the class
        public int max_size = 100;
        public Node top;

        // Variables to return minimum node in the stack
        public int[] min;
        public int min_count = 0;

        // Constructor
        public Stack()
        {
            min = new int[max_size];
        }
        // Function to inform if the stack is empty
        public bool isEmpty()
        {
            return top == null;
        }
        // To insert the node at the top 
        public void push(int data)
        {

            Node node = new Node(data);
            node.next = top;
            top = node;
            // Operation to variate the minimum element of the stack
            if (min_count == 0)
            {
                min[min_count] = data;
                min_count++;
            }
            else
            {
                if (min[min_count - 1] > data)
                {
                    min[min_count] = data;
                    min_count++;
                }
            }
        }
        // Function to remove the first node of the stack
        public int pop()
        {
            if (isEmpty()) throw new NullReferenceException();
            int data = top.data;
            top = top.next;
            //Operation to variate the minimum element of the stack
            if (min[min_count - 1] == data) { min_count--; }
            return data;
        }
        // Function to return the minimum node in the stack
        public int Min()
        {
            return min[min_count - 1];
        }
        static public void Main(String[] args)
        {
            // Testing the data structure
            Stack stack = new Stack();
            stack.push(5);
            stack.push(2);
            stack.push(3);
            stack.push(1);
            Console.WriteLine(stack.Min());
            stack.pop();
            Console.WriteLine(stack.Min());
        }
    }

}