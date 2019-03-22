using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char unos = 'd';

            ArrayList vozila = new ArrayList();
            Automobili automobili = new Automobili();


            while (unos =='d' || unos == 'D')
            {
                Console.WriteLine("za unos automobila 1, za unos brodova 2!");
                Console.Write("vas odabir:");
                char odabir = Console.ReadKey(false).KeyChar;
                Console.WriteLine();

                if (odabir == '1')
                {
                    Automobil automobil = new Automobil();

                    Console.WriteLine("unesi naziv:");
                    automobil.Naziv = Console.ReadLine();
                    Console.WriteLine("unesi boju:");
                    automobil.Boja = Console.ReadLine();
                    Console.WriteLine("unesi KS:");
                    automobil.KS = int.Parse(Console.ReadLine());
                    Console.WriteLine("unesi Ccm:");
                    automobil.Ccm = double.Parse(Console.ReadLine());

                    vozila.Add(automobil);
                    automobili.Add(automobil);

                }
                else if (odabir == '2')
                {
                    Brod brod = new Brod();

                    brod.PromjenaIstisnine += new Brod.PromjenaIstisnineDelegat(PromjenaIstisnine);

                    Console.WriteLine("unesi naziv broda:");
                    brod.Naziv = Console.ReadLine();
                    Console.WriteLine("unesi boju broda:");
                    brod.Boja = Console.ReadLine();
                    Console.WriteLine("unesi ks broda:");
                    brod.KS = int.Parse(Console.ReadLine());
                    Console.WriteLine("unesite istisninu:");
                    brod.Istisnina = double.Parse(Console.ReadLine());

                    vozila.Add(brod);
                }
                else
                {
                    Console.WriteLine("pogresan odabir!");
                }
                Console.WriteLine("zelite li unositi jos vozila (d/n)?");
                unos = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            Console.WriteLine("sva vozila:");
            foreach(object objekt in vozila)
            {
                Vozilo vozilo = (Vozilo)objekt;
                Console.WriteLine("Naziv:{0},Boja:{1},KS:{2},KW:{3}", vozilo.Naziv, vozilo.Boja, vozilo.KS, vozilo.KW());
            }

            Console.WriteLine("automobili:");
            foreach (Automobil automobil in automobili)
            {
                Console.WriteLine(automobil.ToString());
            }
            Console.ReadKey();
        }

        static void PromjenaIstisnine(object o, EventArgs e)
        {
            Brod brod = (Brod)o;
            Console.WriteLine("dogodila se promjena istisnine.");
            Console.WriteLine("nova istisnina:{0}",brod.Istisnina);
        }
    }
    
}
