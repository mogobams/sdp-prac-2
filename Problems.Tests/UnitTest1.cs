using NUnit.Framework;
using System;
using System.Collections;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(typeof(MyTestClass), "TestCases")]
        public string Prefix(string input)
        {
            string result = "";
            int length = input.Length;
            int words = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;

            result = length + "," + words + ":" + input;

            return result;
        }


        //[Test]
        //public void Test1()
        //{
        //    Program p = new Program();
        //    string output = p.Prefix("hello");
        //    Assert.AreEqual("5,1:hello", output);
        //}

        //[Test]
        //public void Test2()
        //{
        //    Program p = new Program();
        //    string output = p.Prefix("");
        //    Assert.AreEqual("0,0:", output);
        //}

        //[Test]
        //public void Test3()
        //{
        //    Program p = new Program();
        //    string output = p.Prefix("what    ...  did you say?? ");
        //    Assert.AreEqual("27,5:what    ...  did you say?? ", output);
        //}
    }

    public class MyTestClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("hello").Returns("5,1:hello");
                yield return new TestCaseData("").Returns("0,0:");
                yield return new TestCaseData("what    ...  did you say?? ").Returns("27,5:what    ...  did you say?? ");
            }
        }
    }
}