using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTest
{
    [TestClass]
    public class HashSetTest
    {
        [TestMethod]
        public void IntersectSets()
        {

            var set1= new HashSet<int> { 1,2,3};
            var set2 = new HashSet<int> { 2, 3, 4 };
            //zwraca elemnty które są wspólne
            set1.IntersectWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));

        }
        [TestMethod]
        public void UnionSets()
        {

            
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            //Połączenie setów
            set1.UnionWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 1,2,3,4 }));

        }

        [TestMethod]
        public void SymmetricExcept()
        {

           
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            //zwraca różnice między setami
            set1.SymmetricExceptWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 1,4 }));

        }

        [TestMethod]
        public void RemoveSet()
        {


            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            //usuwaelement
            set1.Remove(1);

            Assert.AreEqual(2,set1.Count);

        }

        [TestMethod]
        public void RemoveWhereSet()
        {


            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            //usuwa wszystkie elementy które są więkcsze od jeden (możemy zastosować warunek-wyważneie lambda)
            set1.RemoveWhere(x => x > 1);

            Assert.AreEqual(1, set1.Count);

        }

        [TestMethod]
        public void ContainsSet()
        {


            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            //sprawdza czy element jest w naszym zestawie 
            

            Assert.IsTrue(set1.Contains(3));

        }
    }
}
