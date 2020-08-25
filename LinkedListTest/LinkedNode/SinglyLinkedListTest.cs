using LinkedListAlgorithm.LinkedNode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListTest.LinkedNode
{
    [TestClass]
    public class SinglyLinkedListTest
    {
        private SinglyLinkedList<int> _list;
         
        [TestInitialize]
        public void Initialize()
        {
            _list = new SinglyLinkedList<int>();
        }

        [TestMethod]
        public void Create_Emtpy_List_Correct()
        {
            Assert.IsTrue(_list.IsEmpty);
            Assert.IsNull(_list.Head);
            Assert.IsNull(_list.Tail);
        }

        [TestMethod]
        public void Add_First_And_AddLast_Correct()
        {
            _list.AddFirst(1);
            CheckSinglyLinkedListWithSingleState(_list);

            _list.RemoveFirst();
            _list.AddLast(1);

            CheckSinglyLinkedListWithSingleState(_list);
        }

        private void CheckSinglyLinkedListWithSingleState(SinglyLinkedList<int> list)
        {
            Assert.AreEqual(1, list.Count);
            Assert.IsFalse(list.IsEmpty);
            Assert.AreSame(list.Head, list.Tail);
        }

        [TestMethod]
        public void Add_Remove_To_Get_To_State_with_Single_Node_Correct()
        {
            _list.AddFirst(1);
            _list.AddFirst(2);
            _list.RemoveFirst();

            CheckSinglyLinkedListWithSingleState(_list);

            _list.AddLast(2);
            _list.RemoveLast();

            CheckSinglyLinkedListWithSingleState(_list);
        }

        [TestMethod]
        public void Add_First_and_AddLast_AddItems_IncorrectOrder()
        {
            _list.AddFirst(1);
            _list.AddFirst(2);

            Assert.AreEqual(2, _list.Head.Value);
            Assert.AreEqual(1, _list.Tail.Value);

            _list.AddLast(3);

            Assert.AreEqual(3, _list.Tail.Value);
        }

        [TestMethod]
        public void RemoveFist_Empty_List_Throws()
        {
            Assert.ThrowsException<InvalidOperationException>(() => _list.RemoveFirst());
        }
        [TestMethod]
        public void RemoveLast_Empty_List_Throws()
        {
            Assert.ThrowsException<InvalidOperationException>(() => _list.RemoveLast());
        }

        [TestMethod]
        public void RemoveFirst_RemoveLast_Correct()
        {
            _list.AddFirst(1);
            _list.AddFirst(2);
            _list.AddFirst(3);
            _list.AddFirst(4);

            _list.RemoveFirst();
            _list.RemoveLast();

            Assert.AreEqual(3, _list.Head.Value);
            Assert.AreEqual(2, _list.Tail.Value);
        }
    }
}
