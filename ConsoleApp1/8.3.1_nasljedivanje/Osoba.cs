using System;

namespace _8._3._1_nasljedivanje
{
    internal class Osoba
    {
        public DateTime datumNastanka;

        public Osoba()
        {
            this.datumNastanka = DateTime.Now;
            Console.WriteLine("pozvana metoda Osoba:Osoba()");

        }

    }
}