using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba_1
{
    public class Vozilo
    {
        private string naziv;
        public string Naziv
        {
        get {return naziv;}
        set { naziv=value;}
        }
        
        private string boja;
        public string Boja
        {
        get { return boja; }
        set { boja = value; }
        }
        private int ks;
        public int KS
        {
        get {return ks;}
        set {ks = value;}
        }

    public double KW()
{
    return KS * 0.765;
}
    }
}
