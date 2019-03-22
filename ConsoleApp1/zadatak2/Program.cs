using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rijeci = new List<string>();

            while (true)
            {
                Console.WriteLine("unesi rijec: ");
                string rijec = Console.ReadLine();

                if (rijec.ToLower() == "kraj")
                {
                    break;
                }
                else
                {
                    rijeci.Add(rijec);
                }
            }

            List<string> rijeciNaA = (from ria in rijeci where ria.First().ToString().ToLower().Contains("a")select ria).ToList();
            Console.WriteLine();
            Console.Write("rijeci koje pocinju sa \"a\" su: ");

            foreach (string rijec in rijeciNaA)
            {
                Console.Write(rijec + ",");
            }


            List<string> rijeciNaB = (from rib in rijeci where rib.First().ToString().ToLower().Contains("b") select rib).ToList();
            Console.WriteLine();
            Console.WriteLine("rijeci koje pocinju sa \"b\" su: ");

            foreach (string rijec in rijeciNaB)
            {
                Console.Write(rijeci + ",");
            }

            List<string> rijeciNaC = (from ric in rijeci where ric.First().ToString().ToLower().Contains("c") select ric).ToList();
            Console.WriteLine();
            Console.WriteLine("rijeci koje pocinju sa \"c\" su: ");

            foreach (string rijec in rijeciNaC)
            {
                Console.Write(rijeci + ",");
            }

            List<string> ostaleRijeci = (from ri in rijeci where ri.First().ToString().ToLower().Contains("") select ri).ToList();
            Console.WriteLine();
            Console.WriteLine("ostale rijeci su: ");

            foreach (string rijec in ostaleRijeci)
            {
                Console.Write(rijeci + ",");
            }
            Console.ReadKey();
        }
    }
}
