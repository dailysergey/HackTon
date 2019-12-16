using System;
using System.Collections.Generic;

namespace Intersection
{
    class Program
    {
        Node head1, head2;
        /// <summary>
        /// There are two singly linked lists in a system. By some programming error, 
        /// the end node of one of the linked list got linked to the second list, 
        /// forming an inverted Y shaped list. Write a program to get the point where two linked list merge.
        /// </summary>
        public static void Main()
        {
            Program p = new Program(); 
            // creating first linked list 
            p.head1 = new Node(3);
            p.head1.next = new Node(6);
            p.head1.next.next = new Node(9);
            p.head1.next.next.next = new Node(15);
            p.head1.next.next.next.next = new Node(30);

            // creating second linked list 
            p.head2 = new Node(10);
            p.head2.next = new Node(15);
            p.head2.next.next = new Node(30);

            Console.WriteLine("The node of intersection is " + p.GetNode());
        }
        
        int GetNode()
        {
            int countL1 = GetCount(head1);
            int countL2 = GetCount(head2);

            if(countL1 > countL2)
            {
                int d = countL1 - countL2;
                return GetIntersection(d, head1,head2);
            }
            else
            {
                int d = countL2 - countL1;
                return GetIntersection(d, head2, head1);
            }
        }

        int GetIntersection(int d, Node node1, Node node2)
        {
            Node current1 = node1;
            Node current2 = node2;
            for (int i = 0; i < d; i++)
            {
                if (current1 == null)
                    return -1;
                current1 = current1.next;
            }

            while(current1 != null && current2 != null)
            {
                if (current1 == current2)
                    return current1.value;
                current1 = current1.next;
                current2 = current2.next;
            }
            return -1;
        }

        /// <summary>
        ///Get elements count in list
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        int GetCount(Node node)
        {
            Node current = node;
            int count = 0;
            while(current != null)
            {
                count++;
                current = node.next;
            }
            return count;
        }
        class Node
        {
            public int value;
            public Node next;
            public Node(int v)
            {
                value = v;
                next = null;
            }
        }
    }
}
