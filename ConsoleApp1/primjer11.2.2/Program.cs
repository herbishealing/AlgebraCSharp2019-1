using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjer11._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ucitavamo datumsi podatak
            Console.Write("unesite datumski podatak tipa DateTime: ");
            DateTime d1 = DateTime.Parse(Console.ReadLine());
            //ispisujemo datume
            Console.WriteLine("datum: ");
            Console.WriteLine(d1);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToShortDateString());

            //ispisujemo vrijeme
            Console.WriteLine("vrijeme: ");
            Console.WriteLine(d1.ToShortTimeString());

            //ispis dana u tjednu (0=nedjelja)
            Console.WriteLine("dan u tjednu :");
            //ako ne castamo ispisuje se u slovima
            Console.WriteLine(d1.DayOfWeek);
            Console.WriteLine((int)d1.DayOfWeek);

            //korisnicko formatiranje
            //sistemsko vrijeme ispisujemo na preciznost 
            Console.WriteLine("sada je tocno: ");
            d1 = DateTime.Now;

            Console.WriteLine(d1.ToString("MMMM, dddd yyyy HH:mm:ss fff"));

            //koliko dana ima do nove godine
            //1 - kreiram novi datum za Novu godinu
            DateTime dNG = new DateTime(2010, 1, 1);

            //2 - oduzimam tekuci datum od datuma Nove godine
            TimeSpan ts = dNG.Subtract(d1);

            //3 - ispisujemo koliko ima do nove godine
            Console.WriteLine("do Nove godine ima: ");
            Console.WriteLine("dana: "+ts.Days);
            Console.WriteLine("i sati:"+ts.Hours);

            Console.WriteLine("to je ukupno sati:" + ts.TotalHours);
            Console.WriteLine("ili {0} dana, {1} sati, {2} minuta, {3} sekundi .", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
            

        }
    }
}
