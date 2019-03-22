using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba_1
{
    public class Automobil : Vozilo
    {
        private double ccm;
        public double Ccm
        {
        get {return ccm;}
        set{ccm = value;}
        }
        public override string ToString()
{
    return string.Format("naziv:{0}, boja:{1},ks:{2}, kw:{3}", Naziv, Boja, KS, KW());
}
    }
}
