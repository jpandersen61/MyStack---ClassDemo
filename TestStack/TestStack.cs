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
            Stack<int> s = new Stack<int>(10);
            int testElement = 42;
            s.Push(testElement);
            int poppedElement = s.Pop();
            Assert.AreEqual(testElement, poppedElement);
        }

        [TestMethod]
        public void TestPushPopString()
        {
            Stack<string> s = new Stack<string>(10);
            string testElement = "42";
            s.Push(testElement);
            string poppedElement = s.Pop();
            Assert.AreEqual(testElement, poppedElement);
        }

        [TestMethod]
        public void TestPopException()
        {
            Stack<int> s = new Stack<int>(10);
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
            Stack<int> s = new Stack<int>(2);
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
