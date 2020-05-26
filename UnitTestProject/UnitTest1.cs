using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_TwoPositiveValues_returnPositiveSum()
        {
            CustomList<int> thing = new CustomList1<int>();

            int value1 = 7;
            int value2 = 11;
            int expected = 18;
            int actual;

            actual = thing.Add(value1, value2);

            Assert.AreEqual(expected, actual);
        }
        
    }
}
