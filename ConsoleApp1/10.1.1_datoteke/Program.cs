using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._1_datoteke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("molim upisite neki tekst");
            string upis = Console.ReadLine();

            //kreiranje handle-a
            FileStream fs1 = new FileStream("Proba.txt",FileMode.Create);
            //zapisivanje u datoteku
            StreamWriter sw1 = new StreamWriter(fs1);
            sw1.WriteLine(upis);
            sw1.Flush();
            sw1.Close();
            fs1.Close();

            //citanje iz datoteke Proba.txt
            FileStream fs2 = new FileStream("Proba.txt", FileMode.Open);
            StreamReader sr1 = new StreamReader(fs2);
            string procitano = sr1.ReadToEnd();
            Console.WriteLine("ispis iz datoteke Proba.txt");
            Console.WriteLine(procitano);


            Console.ReadKey();
        }
    }
}
