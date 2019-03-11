using System;



namespace domaca_zadaca_ucenik
{
     class Ucenik
    {
        #region svojstva

        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private string oib;
        public string OIB
        {
            get { return oib; }
            set { oib = value; }
        }


        private int racun;
        public int Racun
        {
            get { return racun; }
            set { racun = value; }
        }

        private string telefon;
        private string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        #endregion
        #region metode

        public override string ToString()
        {
            return base.ToString() + ": " + "Pozdrav" + " " + "Ucenik" + ime + prezime + racun;
         }

        public int KonStanje
        {
            get { int konStanje = this.Racun;
                return konStanje - 500;
            }
        }

        #endregion
        #region konstruktori

        public Ucenik()
        {
        }

        public Ucenik(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }

        public Ucenik(string ime, string prezime, string oib)
          : this(ime, prezime)
        {
            this.OIB = oib;
        }

        public Ucenik (string ime, string prezime, string oib, int racun)
            :this(ime, prezime,oib)
        {
            this.Racun = racun;
        }


        #endregion
    }
}