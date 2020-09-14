﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure.Queue
{
    public class QueueArray<T> : IEnumerable<T>
    {
        private T[] _queue;
        private int _head;
        private int _tail;

        public QueueArray()
        {
            _queue = new T[4];
        }

        public QueueArray(int capacity)
        {
            _queue = new T[capacity];
        }

        public bool IsEmpty => Count == 0;
        public int Count => _tail - _head;
        public int Capacity => _queue.Length;

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            return _queue[_head];
        }
        public void Enqueue(T item)
        {
            if(_queue.Length == _tail)
            {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_queue, largerArray, Count);
                _queue = largerArray;
            }

            _queue[_tail++] = item;
        }
        public void Dequeue()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            _queue[_head++] = default(T);

            if (IsEmpty)
                _head = _tail = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _head; i < _tail; i++)
                yield return _queue[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
