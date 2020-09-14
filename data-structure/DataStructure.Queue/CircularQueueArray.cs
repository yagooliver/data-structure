using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Queue
{
    public class CircularQueueArray<T> : IEnumerable<T>
    {
        private T[] _queue;
        private int _head;
        private int _tail;

        public CircularQueueArray()
        {
            _queue = new T[4];
        }

        public CircularQueueArray(int capacity)
        {
            _queue = new T[capacity];
        }

        public bool IsEmpty => Count == 0;
        public int Count => _head <= _tail
            ? _tail - _head
            : _tail - _head + _queue.Length;
        public int Capacity => _queue.Length;

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            return _queue[_head];
        }
        public void Enqueue(T item)
        {
            if (_queue.Length == _tail)
            {
                int countPriorResize = Count;
                T[] newArray = new T[_queue.Length * 2];

                Array.Copy(_queue, _head, newArray, 0, _queue.Length - _head);
                Array.Copy(_queue, 0, newArray, _queue.Length - _head, _tail);

                _queue = newArray;

                _head = 0;
                _tail = countPriorResize;
            }

            _queue[_tail] = item;

            if(_tail < _queue.Length - 1)
            {
                _tail++;
            }else if(_head == _queue.Length)
            {
                _head = 0;
            }

        }
        public void Dequeue()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            _queue[_head++] = default(T);

            if (IsEmpty)
                _head = _tail = 0;
            else if(_head == _queue.Length)
            {
                _head = 0;  
            }
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
