using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAlgorithm.DoublyLinked
{
    public class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode(T value)
        {
            Value = value;
        }

        public DoublyLinkedListNode<T> Next { get; internal set; }
        public DoublyLinkedListNode<T> Previous { get; internal set; }
        public T Value { get; set; }

    }
}
