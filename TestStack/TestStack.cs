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
    }
}
