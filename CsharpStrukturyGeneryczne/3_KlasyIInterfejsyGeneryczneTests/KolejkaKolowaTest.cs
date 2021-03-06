﻿using System;
using _3_KlasyIInterfejsyGeneryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3_KlasyIInterfejsyGeneryczne
{
    [TestClass]
    public class KolejkaKolowaTest
    {
        // [TestMethod]
        //public void NowaKolejkaJestPusta()
        //{
        //    //Assert
        //    var kolejka = new KolejkaKolowa<double>();
        //   // Assert.IsTrue(kolejka.Jestpusty);
        //}

   
        [TestMethod]
        public void KolejkaTrzyElementowaJestPelnaPoTrzechZapisach()
        {
            //Arrange
            var kolejka = new KolejkaKolowa<double>(3);
            kolejka.Zapisz(3.8);
            kolejka.Zapisz(5.8);
            kolejka.Zapisz(9.3);
            //Assert
            Assert.IsTrue(kolejka.JestPelny);
        }


        [TestMethod]
        public void PierwszyWchodziPierwszyWychodzi()
        {
            //Arrange
            var kolejka = new KolejkaKolowa<double>(3);
            var wartosc1 = 4.6;
            var wartosc2 = 3.7;

            kolejka.Zapisz(wartosc1);
            kolejka.Zapisz(wartosc2);

            //Assert
            Assert.AreEqual(wartosc1, kolejka.Czytaj());
            Assert.AreEqual(wartosc2, kolejka.Czytaj());
            //Assert.IsTrue(kolejka.Jestpusty);
        }



        [TestMethod]
        public void NAdpisujeGdyJestWiekszaNizPojemnosc()
        {
            //Arrange
            var kolejka = new KolejkaKolowa<double>(3);
            var wartosci = new[] { 1.2, 2.4, 3.6, 4.8, 5.7,6.1};

            foreach (var wartosc in wartosci)
            {
                kolejka.Zapisz(wartosc);
            }

            //Assert

            Assert.IsTrue(kolejka.JestPelny);
            Assert.AreEqual(wartosci[3],kolejka.Czytaj());
            Assert.AreEqual(wartosci[4], kolejka.Czytaj());
            Assert.AreEqual(wartosci[5], kolejka.Czytaj());
           // Assert.IsTrue(kolejka.Jestpusty);

        }
    }



    
    
}
