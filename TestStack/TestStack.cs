using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStack;

namespace TestStack
{
    [TestClass]
    public class TestStack
    {
        [TestMethod]
        public void TestPushPop()
        {
            Stack s = new Stack(10);
            int testElement = 42;
            s.Push(testElement);
            int poppedElement = s.Pop();
            Assert.AreEqual(testElement, poppedElement);
        }

        [TestMethod]
        public void TestPopException()
        {
            Stack s = new Stack(10);
            int testElement = 42;
            s.Push(testElement);
            int poppedElement = s.Pop();
            Assert.AreEqual(testElement, poppedElement);
            try
            {
                poppedElement = s.Pop();
                Assert.Fail("Popexection occured");
            }

            catch (MyStackIsEmptyException e)
            {

            }
        }

        [TestMethod]
        public void TestPushException()
        {
            Stack s = new Stack(2);
            int testElement = 42;
            s.Push(testElement);
            s.Push(testElement);

            try
            {
                s.Push(testElement);
                Assert.Fail("Push exception occured");
            }

            catch (MyStackIsFullException e)
            {

            }
        }

        
    }
}
