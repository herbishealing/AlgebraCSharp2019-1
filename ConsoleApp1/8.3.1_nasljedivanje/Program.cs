using _8._1._2_Prirucnuik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3._1_nasljedivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik uc1 = new Ucenik();
            Ucenik uc2 = new Ucenik("Anica");
            Ucenik uc3 = new Ucenik("Perica", "Peric");
            
            List<Ucenik> ucenici = new List<Ucenik> { uc1, uc2, uc3 };
            foreach (var item in ucenici)
            {
                Console.WriteLine(item);
               
            }
            Console.ReadLine();
        }
    }
}
