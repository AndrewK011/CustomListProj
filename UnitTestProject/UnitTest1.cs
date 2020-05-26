using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_TwoPositiveValues_returnPositiveSum()
        {
            CustomList<int> list = new CustomList<int>();

            int value1 = 7;
            int value2 = 11;
            int expected = 18;
            int actual;

            actual = list.Add(value1, value2);

            Assert.AreEqual(expected, actual);
        }
        
    }
}
