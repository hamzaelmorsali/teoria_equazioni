using System;
using EquazioniLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsDetermined()
        {
            double a = 3,b=-5;
            bool respattesa = true, resp = Equazioni.IsDetermined(a,b);
            Assert.AreEqual(respattesa, resp);

        }
        [TestMethod]
        public void TestIsDetermined1()
        {
            double a = 0,b=0;
            bool respattesa = false, resp = Equazioni.IsDetermined(a,b);
            Assert.AreEqual(respattesa, resp);

        }
        [TestMethod]
        public void TestIsDetermined2()
        {
            double a = -2,b=3;
            bool respattesa = true, resp = Equazioni.IsDetermined(a,b);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestIsImpossible()
        {
            double b = -2, a = 0;
            bool respattesa = false, resp = Equazioni.IsImpossible(a, b);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestDelta()
        {
            double  a = 0,b=0,c=0;
           double  respattesa = 0, resp = Equazioni.Delta(a,b,c);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestDelta1()
        {
            double a = 1, b = 1, c = 1;
            double respattesa = -3, resp = Equazioni.Delta(a, b, c);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestIsDegree1()
        {
            double a = 0,b=0;
            string respattesa = "l'equazione è indeterminata", resp = Equazioni.IsDegree1(a,b);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestIsDegree1_1()
        {
            double a = 0,b=5;
            string respattesa = "l'equazione è impossibile", resp = Equazioni.IsDegree1(a,b);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestIsDegree1_2()
        {
            double a = 7, b = 5;
            string respattesa = "l'equazione è determinata", resp = Equazioni.IsDegree1(a, b);
            Assert.AreEqual(respattesa, resp);
        }

    }
}
