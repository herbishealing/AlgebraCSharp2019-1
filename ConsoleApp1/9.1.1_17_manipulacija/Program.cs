﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._1_17_manipulacija
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string recenica = "Danas je suncan dan, zato vam Dobar dan!";
            string rijec = "dan"; 
            char slovo = 'n';


            int brojac = 0;
            for (int i = 0; i < recenica.Length; i++)
            {
                if (recenica[i] == slovo)
                {
                    brojac++;
                }
            }
            Console.WriteLine("9.1.1. Znak u rijeci");
            Console.WriteLine("znak {0} pojavljudje se u rijeci {1} {2} puta", slovo, rijec, brojac);

            Console.WriteLine("9.1.2. rijec u recenici");
            //Console.WriteLine("rijec {0} pojavljuje se u recenici '{1}' {2} puta!", rijec, recenica, brojac);


            //recenica = recenica.ToLower();
            string[] nizrijeci = recenica.Split(' ',',','!');
            brojac = 0;
            for (int i = 0; i < nizrijeci.Length; i++)
            {
                if (nizrijeci[i].ToLower() == rijec.ToLower())
                {
                    brojac++;
                }
            }
            Console.WriteLine("rijec {0} pojavljuje se u recenici '{1}' {2} puta!", rijec, recenica, brojac);

            Console.WriteLine("9.1.3. rijeci u novi red");
            nizrijeci = recenica.Split(' ');
            for (int i = 0; i < nizrijeci.Length; i++)
            {
                Console.WriteLine(nizrijeci[i]);
            }


            
            Console.WriteLine("9.1.4. brojac rijeci u recenici");
            Console.WriteLine("recenica '{0}' ima {1} rijeci ", recenica, nizrijeci.Length);


            Console.ReadKey();
        }
    }
}
