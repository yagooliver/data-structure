using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAlgorithm.DoublyLinked
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> Head { get; private set; }
        public DoublyLinkedListNode<T> Tail { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new DoublyLinkedListNode<T>(value));
        }

        private void AddFirst(DoublyLinkedListNode<T> node)
        {
            //save oof the Head
            DoublyLinkedListNode<T> temp = Head;
            //ponint Head to node
            Head = node;

            //insert the rest of the list behind the head
            Head.Next = temp;

            if (IsEmpty)
            {
                Tail = Head;
            }
            else
            {
                //before: 1(head) < ------> 5 <-> 7 -> null
                //after: 3(head) <--------> 1 <-> 5 <-> 7 -> null

                //update "previous" ref of the former head
                temp.Previous = Head;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            AddLast(new DoublyLinkedListNode<T>(value));
        }

        private void AddLast(DoublyLinkedListNode<T> node)
        {
            if(IsEmpty)
                Head = node;
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;

            Count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            //shift head;
            Head = Head.Next;

            Count--;

            if (IsEmpty)
                Tail = null;
            else
                Head.Previous = null;
        }

        public void RemoveLast()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            if(Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Previous.Next = null; //null the last node;
                Tail = Tail.Previous; //shift the tail (now it's the former penultimate node);
            }

            Count--;
        }

        public int Count { get; private set; }

        public bool IsEmpty => Count == 0;
    }
}
