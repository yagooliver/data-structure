using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Queue.Test
{
    [TestClass]
    public class QueueArrayTest
    {
        private QueueArray<int> _queue;

        [TestInitialize]
        public void Initialize()
        {
            _queue = new QueueArray<int>();
        }
        [TestMethod]
        public void Should_IsEmpty_Return_True()
        {
            Assert.IsTrue(_queue.IsEmpty);
        }
        [TestMethod]
        public void Should_Peek_First_Element()
        {
            _queue.Enqueue(1);
            _queue.Enqueue(2);
            _queue.Enqueue(3);
            _queue.Enqueue(4);

            Assert.AreEqual(1, _queue.Peek());
        }

        [TestMethod]
        public void Should_Dequeue_First_Element()
        {
            _queue.Enqueue(1);
            _queue.Enqueue(2);
            _queue.Enqueue(3);

            _queue.Dequeue();

            Assert.AreEqual(2, _queue.Peek());

            _queue.Enqueue(4);
            _queue.Dequeue();

            Assert.AreEqual(3, _queue.Peek());
        }

        [TestMethod]
        public void Should_Compare_Double_Capacity_After_Insert_More_than_default_Capacity()
        {
            _queue.Enqueue(1);
            _queue.Enqueue(2);
            _queue.Enqueue(3);
            _queue.Enqueue(4);
            _queue.Enqueue(5);
            _queue.Enqueue(6);

            Assert.AreEqual(8, _queue.Capacity);
        }

        [TestMethod]
        public void IterateOver_SeveralItems_ExpectedSequence()
        {             
            _queue.Enqueue(1);
            _queue.Enqueue(2);
            _queue.Enqueue(3);

            var q = new List<int>();

            foreach (var cur in _queue)
                q.Add(cur);

            CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, q);
        }

    }
}
