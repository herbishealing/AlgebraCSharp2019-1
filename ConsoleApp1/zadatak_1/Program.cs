using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("unesi broj: ");
           int broj = int.Parse(Console.ReadLine());
            int obrnuto = 0;

            while (broj > 0)
            {
                int ostatak = broj % 10;
                obrnuto = (obrnuto * 10) + ostatak;
                broj = broj / 10;
            }
            Console.WriteLine("obrnuti broj je {0}!", obrnuto);
            Console.ReadKey();
        }
    }
}
