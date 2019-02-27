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
           string  respattesa = "eseiste solo una soluzione", resp = Equazioni.Delta(a,b,c);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestIsDegree2()
        {
            double a = 0;
            bool respattesa = false, resp = Equazioni.IsDegree2(a);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestDelta1()
        {
            double a = 4, b = -9, c = 3;
            string respattesa = "l'equazione ha 2 soluzioni", resp = Equazioni.Delta(a, b, c);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestDelta3()
        {
            double a = 4, b = -9, c = 10;
            string respattesa = "il delta è impossibile", resp = Equazioni.Delta(a, b, c);
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
