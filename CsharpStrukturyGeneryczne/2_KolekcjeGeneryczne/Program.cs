using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kolejka();
            //Stos();
            //HashSet();
            //LinkedList();
            //LinkedList2();
            //Dictionary();
            //DictionaryAdvance();
            //SortedDictionary();
            //SortedList();
            // SotedSet();

            var pracownicy = new SortedDictionary<string, SortedSet<Pracownik>>();

            pracownicy.Add("Sprzedaz", new SortedSet<Pracownik>(new PracownikComparer()));
            pracownicy["Sprzedaz"].Add(new Pracownik { Nazwisko = "Nowak" });
            pracownicy["Sprzedaz"].Add(new Pracownik { Nazwisko = "Głowacki" });
            pracownicy["Sprzedaz"].Add(new Pracownik { Nazwisko = "Czapla" });

            pracownicy.Add("Ksiegowosc", new SortedSet<Pracownik>(new PracownikComparer()));
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Kowal" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Kaczor" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Bogacki" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });

            foreach (var dzial in pracownicy)
            {

                Console.WriteLine(dzial.Key);

                foreach (var pracownik in dzial.Value)
                {
                    Console.WriteLine("\t" + pracownik.Nazwisko);
                }

            }
        }

        private static void SotedSet()
        {
            var set = new SortedSet<int>();

            set.Add(8);
            set.Add(6);
            set.Add(5);
            set.Add(3);
            set.Add(2);
            set.Add(1);


            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            var set2 = new SortedSet<string>();

            set2.Add("tomek");
            set2.Add("iza");
            set2.Add("ola");
            set2.Add("ala");
            set2.Add("piotr");
            set2.Add("beata");
            foreach (var item in set2)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedList()
        {
            var listaPosortowana = new SortedList<int, string>();

            listaPosortowana.Add(3, "trzy");
            listaPosortowana.Add(1, "jeden");
            listaPosortowana.Add(4, "cztery");
            listaPosortowana.Add(2, "dwa");

            foreach (var item in listaPosortowana)
            {
                Console.WriteLine(item.Value);
            }
        }

        private static void SortedDictionary()
        {
            var pracwonicy = new SortedList<string, List<Pracownik>>();
            pracwonicy.Add("Sprzedaż", new List<Pracownik> { new Pracownik { Imie = "Jan",Nazwisko="Kowal" },
                                                             new Pracownik { Imie = "Tomek",Nazwisko="Nowak" },
                                                             new Pracownik { Imie = "Marcin",Nazwisko="Bien" },
                                                           });

            pracwonicy.Add("Informatyka", new List<Pracownik> { new Pracownik { Imie = "Marcin", Nazwisko = "Kowal" },
                                                                new Pracownik { Imie = "Tomek", Nazwisko = "Wróbel" },
                                                              });


            pracwonicy.Add("Księgowość", new List<Pracownik> { new Pracownik { Imie = "Olek",Nazwisko="Kowalski" },
                                                             new Pracownik { Imie = "Bartek",Nazwisko="Nawrocko" },
                                                             new Pracownik { Imie = "Jurek",Nazwisko="Pytel" },
                                                           });



            foreach (var item in pracwonicy)
            {
                Console.WriteLine("Ilosc pracwoników w dziale {0} wynosi {1} ", item.Key, item.Value.Count);
            }
        }

        private static void DictionaryAdvance()
        {
            var pracownicy = new Dictionary<string, List<Pracownik>>();
            pracownicy.Add("Ksiegowosc", new List<Pracownik>() { new Pracownik { Nazwisko = "Nowak" } ,
                                                                 new Pracownik { Nazwisko = "Kowal" },
                                                                 new Pracownik { Nazwisko = "KAczor" } });
            //...


            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });

            pracownicy.Add("Informatyka", new List<Pracownik>() { new Pracownik {Nazwisko= "Kowalski" },
                                                                  new Pracownik { Nazwisko= "Bogacki"  }  });

            foreach (var item in pracownicy)
            {
                Console.WriteLine(item.Key);
                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine("{0}:{1}", item.Key, pracownik.Nazwisko);
                }
            }

            Console.WriteLine("Pracownicy z Księgowości");
            foreach (var item in pracownicy["Ksiegowosc"])
            {
                Console.WriteLine(item.Nazwisko);
            }
        }

        private static void Dictionary()
        {
            Dictionary<string, Pracownik> pracownicy = new Dictionary<string, Pracownik>();
            pracownicy.Add("Nowak", new Pracownik { Nazwisko = "Nowak" });
            pracownicy.Add("Kowal", new Pracownik { Nazwisko = "Kowal" });
            pracownicy.Add("Kaczor", new Pracownik { Nazwisko = "Kaczor" });


            var kowal = pracownicy["Kowal"];

            foreach (var pracownik in pracownicy)
            {

                Console.WriteLine("{0}:{1}", pracownik.Key, pracownik.Value.Nazwisko);
            }
        }

        private static void LinkedList2()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(5);
            list.AddFirst(6);
            list.AddFirst(7);

            // odniesienie do pierwszego elementu listy
            var elementPierwszy = list.First;
            var elementOstatni = list.Last;

            list.AddAfter(elementPierwszy, 10);
            list.AddBefore(elementPierwszy, 20);

            var wezel = list.First;

            while (wezel != null)
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;

            }
        }

        private static void LinkedList()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(5);
            list.AddFirst(6);
            list.AddFirst(7);
            list.AddLast(9);
            list.AddLast(2);




            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }

        private static void HashSet()
        {
            HashSet<int> set = new HashSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);

            foreach (var element in set)
            {

                Console.WriteLine(element);

            }
        }

        private static void Stos()
        {
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Jacek", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });

            Console.WriteLine(" ");
            Console.WriteLine("Stos");
            while (stos.Count > 0)
            {
                var pracownik = stos.Pop();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }

        private static void Kolejka()
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Jacek", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });

            Console.WriteLine("Koleka");
            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}
