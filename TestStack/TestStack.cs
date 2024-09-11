using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStack;
using TestMyStack;

namespace TestStack
{
    [TestClass]
    public class TestStack
    {
        [TestMethod]
        public void TestPushPop()
        {
         //Tests Push and Pop

            //Create a new Stack of size 10 with NO elements
            Stack s = new Stack(10);

            //Push an element to the stack
            int testElement = 42;
            s.Push(testElement);

            //Pop element from the stack
            int poppedElement = s.Pop();

            //Pushed and popped elements should be equal 
            Assert.AreEqual(testElement, poppedElement);
        }

        [TestMethod]
        public void TestPushPop3()
        {
         //Tests Push and Pop

            //Same as TestPushPop, but now with 3 elements on the stack

            //Create a new Stack with NO elements
            Stack s = new Stack(10);

            //Push 3 elements on the stack
            int testElement1 = 42;
            s.Push(testElement1);
            int testElement2 = 99;
            s.Push(testElement2);
            int testElement3 = 13;
            s.Push(testElement3);

            //Popped element should be equal to last pushed element
            int poppedElement = s.Pop();
            Assert.AreEqual(testElement3, poppedElement);

            //Popped element should be equal to second last pushed element
            poppedElement = s.Pop();
            Assert.AreEqual(testElement2, poppedElement);

            //Popped element should be equal to first pushed element
            poppedElement = s.Pop();
            Assert.AreEqual(testElement1, poppedElement);
        }

        [TestMethod]
        public void TestPushException()
        {
            //Tests that an appropriate exception is thrown whenever
            //the stack size is exceeded

            //Create a stack of size 2
            Stack s = new Stack(2);

            //Push 2 elements to the stack
            int testElement = 42;
            s.Push(testElement);
            s.Push(testElement);

            //Try pushing a third one to exceed allowed stack size 
            try
            {
                s.Push(testElement);

                //If we reach here, Push throws no exception
                Assert.Fail("Push exception did NOT occure");
            }

            catch (MyStackIsFullException e)
            {

            }
        }

        [TestMethod]
        public void TestPopException()
        {
         //Test that an appropriate exception is thrown,
         //when popping a stack with NO elements
            
            //Create a stack of any size
            Stack s = new Stack(2);
            
            //Try to Pop an element from the empty stack
            try
            {
                s.Pop();

                //If we reached here, Pop did NOT throw any exception
                Assert.Fail("Pop exception did NOT occure");
            }

            catch (MyStackIsEmptyException e)
            {

            }
        }
    }
}
