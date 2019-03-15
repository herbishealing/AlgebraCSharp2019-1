using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._._1_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum1 = new DateTime(2019, 2, 28);
            DateTime datum2 = new DateTime(2019, 3, 28);
            DateTime datum3 = new DateTime(2019, 2, 28);

            if (datum1 < datum2)
            {
                Console.WriteLine(datum1.ToString()+" je manji od datuma "+datum2.ToString());
            }
            else
            {
                Console.WriteLine(datum1.ToString() + " je veci od datuma " + datum2.ToString());
            }
            Console.WriteLine("trenutno je:"+DateTime.Now);
            Console.WriteLine("trenutno je:" + DateTime.Today);
            //(uvijet)?true:false
            Console.WriteLine((DateTime.IsLeapYear(2019))? "ovo je prijestupna godina?":"ovo nije prijestupna godina");

            Console.WriteLine(datum1 +"datum + 7 dana:"+datum1.AddDays(7));
            Console.WriteLine("danas je:" + DateTime.Today.DayOfWeek);

            Console.ReadLine();
        }
    }
}
