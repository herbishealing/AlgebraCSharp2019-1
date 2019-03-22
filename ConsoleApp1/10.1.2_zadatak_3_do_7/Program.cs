using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._2_zadatak_3_do_7
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream("3or7uNoviRed.txt", FileMode.Create);
            StreamWriter sw1 = new StreamWriter(fs1);


            FileStream fs2 = new FileStream("3or7SaZarezima.txt", FileMode.Create);
            StreamWriter sw2 = new StreamWriter(fs2);


            for (int i = 0; i < 100; i++)
            {
                if (i%3 == 0 || i%7 == 0)
                {
                    sw1.WriteLine(i);
                    sw2.Write("{0},", i);
                }
            }

           
            sw1.Flush();
            sw1.Close();
            fs1.Close();

            sw2.Flush();
            sw2.Close();
            sw2.Close();


            fs1 = new FileStream("3or7uNoviRed.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs1);
            string s = sr.ReadToEnd();
            Console.WriteLine(s);
            sr.Close();
            fs1.Close();

            Console.ReadKey();

        }

    }
}
