﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTest
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void DodawaniePoElemencie()
        {

            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.AddAfter(lista.First,"Ola");

            Assert.AreEqual("Ola", lista.First.Next.Value);
        }

        [TestMethod]
        public void DodawaniePrzedElementem()
        {

            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.AddBefore(lista.First, "Ola");

            Assert.AreEqual("Ola", lista.First.Value);
        }

        [TestMethod]
        public void UsuwanieElementuOStatniego()
        {

            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");

            lista.RemoveLast();

            Assert.AreEqual(lista.First, lista.Last);
          
        }

        [TestMethod]
        public void UsuwanieElementuPierwszego()
        {

            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");

            lista.Remove("Marcin");

            Assert.AreEqual(lista.First.Value, "Tomek");

        }

        [TestMethod]
        public void CzyListaZawieraElement()
        {

            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");

            Assert.IsTrue(lista.Contains("Marcin"));

         
        }

        [TestMethod]
        public void CzyszczenieListy()
        {

            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.Clear();
            Assert.AreEqual(0,lista.Count);


        }
    }
}
