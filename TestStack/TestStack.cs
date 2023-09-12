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
            Stack s = new Stack(10);
            int testElement = 42;
            s.Push(testElement);
            int poppedElement = s.Pop();
            Assert.AreEqual(testElement, poppedElement);
        }

        [TestMethod]
        public void TestPushPop3()
        {
            Stack s = new Stack(10);
            int testElement1 = 42;
            s.Push(testElement1);
            int testElement2 = 99;
            s.Push(testElement2);
            int testElement3 = 13;
            s.Push(testElement3);

            int poppedElement = s.Pop();
            Assert.AreEqual(testElement3, poppedElement);

            poppedElement = s.Pop();
            Assert.AreEqual(testElement2, poppedElement);

            poppedElement = s.Pop();
            Assert.AreEqual(testElement1, poppedElement);
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
                Assert.Fail("Push exception did NOT occure");
            }

            catch (MyStackIsFullException e)
            {

            }
        }
    }
}
