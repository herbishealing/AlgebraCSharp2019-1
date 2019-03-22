using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._5._1_eventi
{
   public class Osoba
    {
        //deklaracija dogadaja
        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs e);
        public event NaPromjenuImenaDelegat NaPromjenuImena;

        //svojstva
        private string ime;
        public string Ime
        {
            get { return ime; }
            set
            {
                ime = value;
                if(NaPromjenuImena != null)
                {
                    NaPromjenuImena(this, new EventArgs());
                }
            }
        }

    }
}
