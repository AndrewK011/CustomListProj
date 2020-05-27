using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_IntegerToList_ReturnIntegerAdded()
        {
            CustomList<int> list = new CustomList<int>();

            int value1 = 7;         
            int expected = 7;
            int actual;

            list.Add(value1);

            actual = list[0];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_IntegerToList_CountIncreaseByOne()
        {
            CustomList<int> list = new CustomList<int>();

            int value1 = 5;         
            int expected = 1;

            list.Add(value1);
            int actual = list.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FiveIntsToList_ReturnFifthIntAdded()
        {
            CustomList<int> list = new CustomList<int>();

            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            
            
            int expected = 5;
            int actual;

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);

            actual = list[4];

            Assert.AreEqual(expected, actual);
        }      

        [TestMethod]
        public void Add_DoubleToList_ReturnDoubleAdded()
        {
            CustomList<double> list = new CustomList<double>();

            double value1 = 9.5;         
            double expected = 9.5;
            double actual;

            list.Add(value1);

            actual = list[0];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_BoolToList_ReturnBoolAdded()
        {
            CustomList<bool> list = new CustomList<bool>();

            bool value1 = true;         
            bool expected = true;
            bool actual;

            list.Add(value1);

            actual = list[0];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_StringToList_ReturnStringAdded()
        {
            CustomList<string> list = new CustomList<string>();

            string value1 = "This is a string.";
            string expected = "This is a string.";
            string actual;

            list.Add(value1);

            actual = list[0];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]     
        public void Remove_FirstIntFromList_SecondIntNowInFirstIndex()
        {
            CustomList<int> list = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            list.Remove(1);

            int expected = 2;
            int  actual = list[0];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]     
        public void Remove_FirstIntFromList_CountDecreasesByOne()
        {
            CustomList<int> list = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            list.Remove(1);

            int expected = 4;
            int  actual = list.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FirstTrueFromList_FirstIndexIsFalse()
        {
            CustomList<bool> list = new CustomList<bool>();

            list.Add(true);
            list.Add(false);
            list.Add(true);
            list.Add(false);
            list.Add(true);

            list.Remove(true);

            bool expected = false;
            
            bool actual = list[0];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_IntNotInList_ReturnFalse()
        {
            CustomList<int> list = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            

            bool expected = false;
            bool actual = list.Remove(6); 

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_IntInList_ReturnTrue()
        {
            CustomList<int> list = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            

            bool expected = true;
            bool actual = list.Remove(4); 

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_StringFromList_ThirdIndexNowInSecond()
        {
            CustomList<string> list = new CustomList<string>();

            string value1 = "This is a string.";
            string value2 = "This is also a string.";
            string value3 = "Is this a string?";

            string expected = "Is this a string?";
            string actual;

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Remove(value2);

            actual = list[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_StringFromList_ThirdIndexNowInSecond()
        {
            CustomList<string> list = new CustomList<string>();

            string value1 = "This is a string.";
            string value2 = "This is also a string.";
            string value3 = "Is this a string?";

            string expected = "Is this a string?";
            string actual;

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Remove(value2);

            actual = list[1];

            Assert.AreEqual(expected, actual);
        }



    }
}
