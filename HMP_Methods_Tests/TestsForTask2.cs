using HMP_Methods_Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMP_Methods_Tests
{
    [TestClass]
    public class TestsForTask2
    {

        [TestMethod]
        public void TestQueueSize0()
        {
            Queue queue = new Queue();
            Assert.AreEqual(0, queue.Size());
        }

        [TestMethod]
        public void TestAddelementToQueue()
        {
            Queue queue = new Queue();
            queue.Push(10);

            Assert.AreEqual(1, queue.Size());
        }

        [TestMethod]
        public void TestGetFirstElementInQueue()
        {
            Queue queue = new Queue();
            queue.Push(10);
            queue.Push(20);

            Assert.AreEqual(10, queue.Front());
        }

        [TestMethod]
        public void TestPopElementInQueue()
        {
            Queue queue = new Queue();
            queue.Push(10);
            queue.Push(20);

            int popped = queue.Pop();
            Assert.AreEqual(10, popped);

            popped = queue.Pop();
            Assert.AreEqual(20, popped);

            Assert.AreEqual(0, queue.Size());
        }

        [TestMethod]
        public void TestClearQueue()
        {
            Queue queue = new Queue();
            queue.Push(10);
            queue.Push(20);
            queue.Push(30);

            queue.Clear();

            Assert.AreEqual(0, queue.Size());
        }

        [TestMethod]
        public void TestHandleInputPush()
        {
            Queue queue = new Queue();

            string result = HMP_Methods_Task2.Program.HandleInput("push 1", queue);

            Assert.AreEqual(1, queue.Front());
            Assert.AreEqual("ok", result);
        }

        [TestMethod]
        public void TestHandleInputPop()
        {
            Queue queue = new Queue();
            queue.Push(10);

            string result = HMP_Methods_Task2.Program.HandleInput("pop", queue);

            Assert.AreEqual("10", result);
            Assert.AreEqual(0, queue.Size());
        }

        [TestMethod]
        public void TestHandleInputBack()
        {
            Queue queue = new Queue();
            queue.Push(10);

            string result = HMP_Methods_Task2.Program.HandleInput("front", queue);

            Assert.AreEqual("10", result);
        }

        [TestMethod]
        public void TestHandleInputSize()
        {
            Queue queue = new Queue();
            queue.Push(1);
            queue.Push(2);

            string result = HMP_Methods_Task2.Program.HandleInput("size", queue);


            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void TestHandleInputClear()
        {
            Queue queue = new Queue();

            queue.Push(10);
            queue.Push(2);
            queue.Push(1);

            string result = HMP_Methods_Task2.Program.HandleInput("clear", queue);

            Assert.AreEqual(0, queue.Size());
            Assert.AreEqual("ok", result);
        }

        [TestMethod]
        public void TestHandleInputExit()
        {
            string result = HMP_Methods_Task2.Program.HandleInput("exit", new Queue());

            Assert.AreEqual("Bye", result);
        }


    }
}
