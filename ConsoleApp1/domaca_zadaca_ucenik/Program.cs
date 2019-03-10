using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaca_zadaca_ucenik
{
    class Program
    {
        static void Main(string[] args)
        {


            Ucenik U1 = new Ucenik(Andrija, Andrasek, 1111111111111, r1);
            Ucenik U2 = new Ucenik(Boris, Barisic, 2222222222222, r2);
            Ucenik U3 = new Ucenik(Drago, Dragic, 3333333333333, r3);

            List<Ucenik>listaUcenika = new List<Ucenik>();
            listaUcenika.Add(U1);
            listaUcenika.Add(U2);
            listaUcenika.Add(U3);

        }
    }
}
