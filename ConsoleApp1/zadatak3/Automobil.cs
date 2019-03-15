using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak3
{
    class Automobil
    {
        string Naziv;
        int GodinaProiuvodnje;
        double OsnovnaCijena;

        public string Naziv1 { get => Naziv; set => Naziv = value; }
        public int GodinaProiuvodnje1 { get => GodinaProiuvodnje; set => GodinaProiuvodnje = value; }
        public double OsnovnaCijena1 { get => OsnovnaCijena; set => OsnovnaCijena = value; }

        public class Starost
        {
            DateTime datum = new DateTime();
            
        }
    }
}
