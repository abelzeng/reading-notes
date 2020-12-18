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
        public void TestMyList()
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
        public void TestYieldList()
        {
            YieldList<int> yieldList = new YieldList<int>();
            yieldList.Add(1);
            yieldList.Add(2);
            yieldList.Add(3);
            yieldList.Add(4);
            foreach (var item in yieldList)
            {
                Console.WriteLine(item);
            }
            foreach (var item in yieldList)
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
