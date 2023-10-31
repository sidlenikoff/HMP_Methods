using HMP_Methods_Task1;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net.Http.Headers;

namespace HMP_Methods_Tests
{
    [TestClass]
    public class TestsForTask1
    {
        [TestMethod]
        public void TestStackSize0()
        {
            Stack stack = new Stack();
            Assert.AreEqual(0, stack.Size());
        }

        [TestMethod]
        public void TestGetStackElement()
        {
            Stack stack = new Stack();
            stack.Push(10);
            int backValue = stack.Back();
            Assert.AreEqual(10, backValue);
        }

        [TestMethod]
        public void TestAddElementToStack()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(10);
            Assert.AreEqual(2, stack.Size());
        }

        [TestMethod]
        public void TestStackPop()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            int poppedValue = stack.Pop();
            Assert.AreEqual(20, poppedValue);
            Assert.AreEqual(1, stack.Size());
        }

        [TestMethod]
        public void TestStackClear()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Clear();
            Assert.AreEqual(0, stack.Size());
        }
        
        [TestMethod]
        public void TestHandleInputPush()
        {
            Stack stack = new Stack();
            
            string result = HMP_Methods_Task1.Program.HandleInput("push 1", stack);

            Assert.AreEqual(1, stack.Back());
            Assert.AreEqual("ok", result);
        }

        [TestMethod]
        public void TestHandleInputPop()
        {
            Stack stack = new Stack();
            stack.Push(10);
            
            string result = HMP_Methods_Task1.Program.HandleInput("pop", stack);

            Assert.AreEqual("10", result);
            Assert.AreEqual(0, stack.Size());
        }

        [TestMethod]
        public void TestHandleInputBack()
        {
            Stack stack = new Stack();
            stack.Push(10);
            
            string result = HMP_Methods_Task1.Program.HandleInput("back", stack);

            Assert.AreEqual("10", result);
        }

        [TestMethod]
        public void TestHandleInputSize()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            
            string result = HMP_Methods_Task1.Program.HandleInput("size", stack);


            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void TestHandleInputClear()
        {
            Stack stack = new Stack();

            stack.Push(10);
            stack.Push(2);
            stack.Push(1);

            string result = HMP_Methods_Task1.Program.HandleInput("clear", stack);

            Assert.AreEqual(0, stack.Size());
            Assert.AreEqual("ok", result);
        }

        [TestMethod]
        public void TestHandleInputExit()
        {
            string result = HMP_Methods_Task1.Program.HandleInput("exit", new HMP_Methods_Task1.Stack());

            Assert.AreEqual("Bye", result);
        }
    }
}