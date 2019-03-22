using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._2_primjer_klasa_path_file_directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapa u kojoj se izvrsava nas program:" );
            Console.WriteLine(Environment.CurrentDirectory);

            Console.Write("Postoji li file Proba.txt u izvrsnoj mapi:");

            //Path klasa
            string mojaPutanja = System.IO.Path.Combine(Environment.CurrentDirectory, "Proba.txt");

            //File klasa
            Console.WriteLine(File.Exists(mojaPutanja));

            //Directory klasa, provjerava jel postoji file
            if (!Directory.Exists("Proba"))
            {
                //ako ne postoji folder proba kreiram ga
                Directory.CreateDirectory("Proba");
            }

            //ispisujem sve foldere na C-u
            Console.WriteLine("Direktoriji na D:");
            string[] sDirs = Directory.GetDirectories(@"D:\");
                foreach (string sDir in sDirs)
            {
                Console.WriteLine(sDir);
            }

            //ispisujem sve fileove na C-u
            Console.WriteLine("Datoteke na D:");
            string[] sFiles = Directory.GetFiles(@"D:\");
            foreach(string sFile in sFiles)
            {
                Console.WriteLine(Path.GetFileName(sFile));
            }
            Console.ReadKey();
        }
    }
}
