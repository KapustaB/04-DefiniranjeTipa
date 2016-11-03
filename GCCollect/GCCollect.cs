﻿using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class Program
    {
        // TODO: Prekopirati definiciju klase s destruktorom iz prethodnog primjera
        // TODO: Staviti točku prekida (breakpoint) u destruktor, pokrenuti program i pogledati 
        //zadnje ispise prije prekida izvođenja.
        public class KlasaSDestruktorom
        {
            ~KlasaSDestruktorom()
            {
                Console.WriteLine($"Destruktor objekta br. {0}.");
                Debug.WriteLine($"Destruktor objekta br. {0}.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ušao sam u 'Main'");

            for (int i = 0; i < 1000; i++)
            {
                KlasaSDestruktorom ksd = new KlasaSDestruktorom();
            }

            Console.WriteLine("*** Pozivamo GC.Collect() ***");
            Debug.WriteLine("*** Pozivamo GC.Collect() ***");

            // explicitno pozivamo sustav za skupljanje smeća
            // redoslijed uništavanja objekata nije unaprijed određen!
            GC.Collect();

            Debug.WriteLine("*** GOTOVO!!! ***");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

            Debug.WriteLine("*** SADA JE KONAČNO!!! ***");
        }
    }
}
