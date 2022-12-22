using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab_teamcity;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // исходные данные
            int a = 3;
            int b = 5;
            int expected = 8;

            // получение значения с помощью тестируемого метода
            Program g = new Program();
            int actual = g.Plus(a, b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        public void TestMethod2()
        {
            // исходные данные
            int a = 3;
            int b = 5;
            int expected = 8;

            // получение значения с помощью тестируемого метода
            Program g = new Program();
            int actual = g.Plus(a, b);

            // сравнение ожидаемого результата с полученным
            Assert.AreNotEqual(expected + 1, actual);
        }
        public void TestMethod3()
        {
            // исходные данные
            int a = -3;
            int b = 5;
            int expected = 2;

            // получение значения с помощью тестируемого метода
            Program g = new Program();
            int actual = g.Plus(a, b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }
    }
}
