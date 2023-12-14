using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }
        public Node Last { get; set; }  
        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list
            // consider when the list is empty

            // create a new node with the given data

            Node temp = new Node(val);

            if (First == null)
            {
                First = temp;
                Last = temp;
                return;
            }

            Last.Next = temp;
            Last=temp;
        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty

            if (First == null)
            {
                Console.WriteLine("list is empty");
                return;
            }

            if (First==Last )
            {
                if (First.Data == key)
                {
                    First = null;
                    Last = null;
                    return;
                }
                
                    Console.WriteLine("key not found");
                    return;

            }

            Node move = First;
            while (move.Next!=null)
            {
                if (move.Next.Data != key)
                {
                    move = move.Next;
                }
                else
                {
                    move.Next = move.Next.Next;
                    return;
                }

            }

            Console.WriteLine("key not found");


        }
        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list
            Last.Next=other_list.First;
            Last=other_list.Last;
           
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next 

            if (First == null || First == Last)
                return;

            if (First.Next==Last )
            {
                Last.Next = First;
                First = Last;
                Last= First.Next;
                Last.Next = null ;
                return;
            }

            Node prev, curr, next;
            prev = null;
            curr = First;
           
            Last = First;
            while (curr!=null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            First = prev; 

        }
    }
}
