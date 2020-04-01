using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTest
{
    [TestClass]
    public class ListaTest
    {
        [TestMethod]
        public void ListaMozemyDodawacNaKoniec()
        {
            var ListaLiczb = new List<int> { 1,2,3};

            ListaLiczb.Add(4);

            Assert.AreEqual(4, ListaLiczb[3]);

        }

        [TestMethod]
        public void ListaMozemyDodawacNaPozycji()
        {
            var ListaLiczb = new List<int> { 1, 2, 3 };

            ListaLiczb.Insert(1, 8);

            Assert.AreEqual(8, ListaLiczb[1]);

        }


        [TestMethod]
        public void ListaMozemyUsuwacElement()
        {
            var ListaLiczb = new List<int> { 1, 2, 3 };

            ListaLiczb.Remove(2);

            Assert.IsTrue(ListaLiczb.SequenceEqual(new[] { 1, 3 }));

        }

        [TestMethod]
        public void ListaMozemyUsuwacElementNaPozycji()
        {
            var ListaLiczb = new List<int> { 1, 2, 3 };

            ListaLiczb.RemoveAt(2);

            Assert.IsTrue(ListaLiczb.SequenceEqual(new[] { 1, 2 }));

        }

        [TestMethod]
        public void ListaMozemyWyszukiwacIndex()
        {
            var ListaLiczb = new List<int> { 1, 2, 3 };


            Assert.AreEqual(ListaLiczb.IndexOf(3),2);

        }



        [TestMethod]
        public void ListaMozemyWyszukiwacCzyZawiera()
        {
            var ListaLiczb = new List<int> { 1, 2, 3 };


            Assert.IsTrue(ListaLiczb.Contains(3));

        }

        [TestMethod]
        public void ListaMozemyDodawacNaKoniecZakresLiczb()
        {
            var ListaLiczb = new List<int> { 1, 2, 3 };
            var zakres = new List<int> { 4,5,6,7};
            ListaLiczb.AddRange(zakres);

            Assert.AreEqual(7, ListaLiczb[6]);

        }
    }
}
