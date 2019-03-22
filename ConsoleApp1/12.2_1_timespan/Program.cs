using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2_1_timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum1 = new DateTime(2019, 2, 22);
            DateTime datum2 = new DateTime(2019, 3, 28);
            TimeSpan interval1 = datum2 - datum1;

            Console.WriteLine("intervali izmedju {0} i {1} je {2}", datum1,datum2,interval1);
            Console.WriteLine("u satima..."+interval1.Hours);
            Console.WriteLine("u minutama..." + interval1.Minutes);
            Console.WriteLine("u danima..." + interval1.Days);

            Console.WriteLine("u satima ukupno..." + interval1.TotalHours);
            Console.WriteLine("u minutama ukupno..." + interval1.TotalMinutes);
            
            Console.ReadKey();
        }
    }
}
