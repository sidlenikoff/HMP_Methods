using HMP_Methods_Task4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMP_Methods_Tests
{
    [TestClass]
    public class TestsForTask4
    {
        [TestMethod]
        public void TestListPushBack()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.PushBack(1);
            list.PushBack(200);

            Assert.AreEqual(2, list.Size());
            Assert.AreEqual(200, list.GetLast());
        }

        [TestMethod]
        public void TestListPushFront()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.PushFront(1);
            list.PushFront(200);

            Assert.AreEqual(2, list.Size());
            Assert.AreEqual(200, list.GetFirst());
        }

        [TestMethod]
        public void TestListFindValue()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(1, 2, 3, 4, 5, 4);

            var indecies = list.FindValue(4);

            Assert.AreEqual(2, indecies.Count);
            Assert.AreEqual(4, indecies[0]);
            Assert.AreEqual(6, indecies[1]);

        }

        [TestMethod]
        public void TestListElementNotFound()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(1, 2, 3, 4, 5, 4);

            var result = list.FindValue(19);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void TestPopFront()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(1,2, 3, 4, 5, 4);

            int popped = list.PopFront();

            Assert.AreEqual(1, popped);
            Assert.AreEqual(5, list.Size());
        }

        [TestMethod]
        public void TestPopBack()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(1,2,3,4,5,4);

            int popped = list.PopBack();

            Assert.AreEqual(4, popped);
            Assert.AreEqual(5, list.Size());
        }

        [TestMethod]
        public void TestClearList()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(1, 2, 3, 4, 5, 4);

            list.Clear();
            try
            {
                list.GetFirst();
                Assert.Fail();
            }
            catch (InvalidOperationException ex)
            {
                Assert.IsTrue(true);
            }

            try
            {
                list.GetLast();
                Assert.Fail();
            }
            catch (InvalidOperationException ex)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TestListRemoveValue()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(1, 2, 3, 4, 5, 4);

            list.RemoveValue(4);

            Assert.AreEqual("1 2 3 5", list.ToString());
        }
    }
}
