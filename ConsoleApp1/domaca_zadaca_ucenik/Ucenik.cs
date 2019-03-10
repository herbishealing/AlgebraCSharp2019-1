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


        private string racun;
        public string Racun
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
            return "Pozdrav" + "Ucenik" + ime + prezime + racun;
        }


        #endregion
        #region konstruktori

        public Ucenik() { }

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

        public Ucenik (string ime, string prezime, string oib, string racun)
            :this(ime, prezime,oib)
        {
            this.Racun = racun;
        }


        #endregion
    }
}