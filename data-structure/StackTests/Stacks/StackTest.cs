using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks.ArrayLifo;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackTests.Stacks
{
    [TestClass]
    public class StackTest
    {
        private ArrayStack<int> _stack;
        [TestInitialize]
        public void Initialize()
        {
            _stack = new ArrayStack<int>();
        }
        [TestMethod]
        public void IsEmpty_EmptyStack_Returns_True()
        {
            Assert.IsTrue(_stack.IsEmpty);
        }

        [TestMethod]
        public void Count_Push_One_Item_Returns_One()
        {
            _stack.Push(1);

            Assert.AreEqual(1, _stack.Count);
            Assert.IsFalse(_stack.IsEmpty);
        }

        [TestMethod]
        public void Pop_EmptyStack_ThrowsException()
        {
            Assert.ThrowsException<InvalidOperationException>(() => _stack.Pop());
        }

        [TestMethod]
        public void Peek_EmptyStack_ThrowsException()
        {
            Assert.ThrowsException<InvalidOperationException>(() => _stack.Peek());
        }

        [TestMethod]
        public void Push_Two_Items_And_Pop_Returns_Head_Item()
        {
            _stack.Push(1);
            _stack.Push(2);

            Assert.AreEqual(2, _stack.Peek());
        }


        [TestMethod]
        public void Peek_Push_Two_Items_And_Pop_Returns_Head_Element()
        {
            _stack.Push(1);
            _stack.Push(2);

            _stack.Pop();

            Assert.AreEqual(1, _stack.Peek());
        }
    }
}
