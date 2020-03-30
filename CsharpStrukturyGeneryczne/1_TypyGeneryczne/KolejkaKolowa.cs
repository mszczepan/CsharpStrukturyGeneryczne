namespace _1_TypyGeneryczne
{
    public class KolejkaKolowa
    {
        private double[] buffor;
        private int poczatekBufora;
        private int koniecBufora;
        public KolejkaKolowa() : this(pojemnosc: 5)
        {

        }

        public KolejkaKolowa(int pojemnosc)
        {
            buffor = new double[pojemnosc + 1];
            poczatekBufora = 0;
            koniecBufora = 0;

        }


        public void Zapisz(double wartosc)
        {
            buffor[koniecBufora] = wartosc;
            koniecBufora = (koniecBufora + 1) % buffor.Length;

            if (koniecBufora == poczatekBufora)
                poczatekBufora = (poczatekBufora + 1) % buffor.Length;

        }

        public double Czytaj()
        {
            var wynik = buffor[poczatekBufora];
            poczatekBufora = (poczatekBufora + 1) % buffor.Length;
            return wynik;
        }

        public int Pojemnosc
        {
            get
            {
                return buffor.Length;
            }
        }



        public bool Jestpusty
        {
            get
            {

                return koniecBufora == poczatekBufora;
            }

        }

        public bool JestPelny
        {
            get
            {
                return (koniecBufora + 1) % buffor.Length == poczatekBufora;
            }


        }
    }
}
