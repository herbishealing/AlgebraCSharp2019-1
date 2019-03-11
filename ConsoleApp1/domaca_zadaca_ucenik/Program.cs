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
            

                Ucenik U1 = new Ucenik("Andrija", "Andrasek", "1111111111111", 2000);
                Ucenik U2 = new Ucenik("Boris", "Barisic", "2222222222222", 3000);
                Ucenik U3 = new Ucenik("Drago", "Dragic", "3333333333333", 4000);

                List<Ucenik> listaUcenika = new List<Ucenik>();
                listaUcenika.Add(U1);
                listaUcenika.Add(U2);
                listaUcenika.Add(U3);

            Console.WriteLine("pocetno stanje:\n");

                listaUcenika.ForEach(Ucenik => IspisUcenika(Ucenik));

            Console.WriteLine("\nkonacno stanje:\n");

                listaUcenika.ForEach(Ucenik => IspisUcenika2(Ucenik));

            

                Console.ReadKey();
            
        }
        private static void IspisUcenika2(Ucenik ucenik)
        {
            Console.WriteLine("Ucenik: " + ucenik.Ime + " " + ucenik.Prezime + " " + ucenik.KonStanje);
        }


                private static void IspisUcenika(Ucenik ucenik)
                {
                    Console.WriteLine("Ucenik: " + ucenik.Ime + " " + ucenik.Prezime + " " + ucenik.Racun );
                }
            
       
        
    }
}
