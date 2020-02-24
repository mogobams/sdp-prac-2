using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program p = new Program();
            string output = p.Prefix("hello");
            Assert.AreEqual("5,1:hello", output);
        }

        [Test]
        public void Test2()
        {
            Program p = new Program();
            string output = p.Prefix("");
            Assert.AreEqual("0,0:", output);
        }

        [Test]
        public void Test3()
        {
            Program p = new Program();
            string output = p.Prefix("what    ...  did you say?? ");
            Assert.AreEqual("27,5:what    ...  did you say?? ", output);
        }
    }
}