using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211Lab8
{
    public class LinkedList
    {
        //Head node always has null value for Data. 
        //Head node cannot be replaced.
        //Empty list's head node has null value for Next.

        public Node Head { get; set; }
        public int Count { get; set; }

        public LinkedList()
        {
            Head = new Node();
            Count = 0;
        }

        public void AddFirst(string value)
        {
            Node newNode = new Node(null, value);

            //multiple assignments in one line: https://stackoverflow.com/questions/804706/swap-two-variables-without-using-a-temporary-variable
            //This should work regardless of whether Head.Next is null.
            (Head.Next, newNode.Next) = (newNode, Head.Next);
            Count++;
        }

        public void AddLast(string value)
        {
            Node newNode = new Node(null, value);

            Node temp = Head;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            Count++;
        }

        public void RemoveFirst()
        {
            if (Head.Next == null)
            {
                throw new InvalidOperationException("Attempt to remove the first node in an empty list.");
            }

            Head.Next = Head.Next.Next;
            Count--;
        }

        public void RemoveLast()
        {
            if (Head.Next == null)
            {
                throw new InvalidOperationException("Attempt to remove the last node in an empty list.");
            }

            Node temp = Head;

            while (temp.Next.Next != null) //temp.Next cannot be null because that would throw.
            {
                temp = temp.Next;
            }

            temp.Next = null;
            Count--;
        }

        public string? GetValue(int index)
        {
            if (index > Count || index < 1)
            {
                //Another option is to throw index out of range. But I believe returning null is more appropriate.
                return null;
            }

            Node temp = Head;

            for (int i = 0; i < index; i++)
            {
                temp = temp.Next; //temp.Next cannot start out as null because that would throw.
            }

            return temp.Data;
        }
    }
}
