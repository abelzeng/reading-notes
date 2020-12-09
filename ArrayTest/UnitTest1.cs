using ArrayLearning;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ArrayTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            MyList<int> myList = new MyList<int>(10);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
        [TestMethod]
        public void TestHelloCollection()
        {
            HelloCollection helloCollection = new HelloCollection();
            foreach (var item in helloCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
