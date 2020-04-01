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

            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Jacek", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });

            Console.WriteLine("Koleka");
            while (kolejka.Count>0)
            {
                var  pracownik= kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }


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
    }
}
