using _8._1._2_Prirucnuik;
using System;
namespace _8._3._1_nasljedivanje
{
    internal class Ucenik : Osoba, IUcenik
    {
       // private string ime = "";
        //public DateTime datumNastanka;
        //public string prezime = "";
        public int ocjenaIzMatematike = 0;
        public int ocjenaIzEngleskog = 0;
        public int ocjenaIzBiologije = 0;

        //public string Ime {
          //  get => ime;
            //set => ime = ToUpper.FirstCharToUpper(value);
       // }
        //ovaj radi sam kod direktnog poziva
        //Ucenik u99=new Ucenik()
        public Ucenik()
        {
            this.datumNastanka = DateTime.Now;
            Console.WriteLine("pozvana metoda Ucenik:Ucenik()");

        }

        public Ucenik(string v) : base()
        {
            this.Ime = v;
        }
        public Ucenik(string v, string prez) :this (v)
        {
            this.Ime = v;
            this.prezime = prez;
        }

        public double Prosjek()
        {
            double prosjek = 0;
            prosjek = (double)(ocjenaIzBiologije + ocjenaIzEngleskog + ocjenaIzMatematike) / 3;

            return prosjek;
            //throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Moje ime je " + this.Ime + " a moj prosjek je: " + this.Prosjek();
        }
    }
}