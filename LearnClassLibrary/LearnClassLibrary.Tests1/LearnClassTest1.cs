using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnClassLibrary.Tests1
{
    [TestClass]
    public class LearnClassTest1
    {
        [TestMethod]
        public void test_TimeInSecunds()
        {
            int a=2;
            int b = 3;
            int expected = 7380;

            LearnClass c= new LearnClass();
            int actual=c.TimeInSecunds(a,b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_Secunds()
        {
            int a = 7265;
            //int r = 0;
            (int,int) expected = (2,1);

            LearnClass c = new LearnClass();
            (int,int) actual = c.Secunds(a);

            Assert.AreEqual(expected, actual);
        }
    }
}
