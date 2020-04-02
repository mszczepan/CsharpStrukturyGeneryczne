using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTest
{
    [TestClass]
    public class KolejkaTest
    {
        [TestMethod]
        public void UzyciePeek()
        {
            //zwraca obiekt z czoła kolejki ale nie usuwa z kolejki 
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            Assert.AreEqual(1, kolejka.Peek());
        }
        [TestMethod]
        public void UzycieMEtodyContains()
        {
            //sprawdza czy dany element jest w kolejce
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            Assert.IsTrue(kolejka.Contains(3));
        }

        [TestMethod]
        public void UzycieMetodyToArray()
        {
            //przeglądanie kolejki poprzez rzutowanie na tablice
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            var tablica = kolejka.ToArray();

            kolejka.Dequeue();
            Assert.AreEqual(1 ,tablica[0]);
            Assert.AreEqual(3, kolejka.Count);

           
        }


        [TestMethod]
        public void UzycieMetodyClear()
        {
            //wyczyszczenie kolejki
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);
            kolejka.Clear();
       
            Assert.AreEqual(0, kolejka.Count);
            

        }

    }
}
