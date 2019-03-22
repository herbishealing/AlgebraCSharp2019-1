using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba_1
{
    public class Brod : Vozilo
    {
        public delegate void PromjenaIstisnineDelegat(object o, EventArgs e);
        public event PromjenaIstisnineDelegat PromjenaIstisnine;

        private double istisnina;
        public double Istisnina
        {
            get { return istisnina; }
            set
            {
                istisnina = value;
                if (PromjenaIstisnine != null)
                {
                    PromjenaIstisnine(this, new EventArgs());
                }
            }
        }
    }
}
