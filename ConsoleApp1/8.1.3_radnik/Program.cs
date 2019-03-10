using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._3_radnik
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciranje novog objekta  R1 klase Radnik
            Radnik R1 = new Radnik("marko", "markovic", "43677");

            //korisnik mora ispravno unijeti broj bodova

            bool provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("unesite broj bodova: ");
                try
                {
                    R1.BrojBodova = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }
                catch (FormatException ex)//hvatam posebne greske
                {
                    Console.WriteLine("greska: " + ex.Message);
                }
                catch (Exception ex) //hvatam ostale greske
                {
                    Console.WriteLine("greska: " + ex.Message);
                }
            }
            provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.WriteLine("unesi vrijednost boda:");
                try
                {
                    R1.VrijednostBoda= double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("greska: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("greska :" + ex.Message);
                }
            }
            //ispis
            Console.WriteLine("Radnik: " + R1.Ime + " " + R1.Prezime);
            Console.WriteLine("Neto: " + R1.NetoIzracunPlace());
            Console.WriteLine("Porez: " + R1.Porez);
            Console.WriteLine("Brute :" + R1.BrutoIzracunPlace());

            Console.ReadKey();
        }
    }
}
