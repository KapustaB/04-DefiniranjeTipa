﻿using System;

namespace Vsite.CSharp
{
    public class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;
    }

    public class KonstruktorKlase
    {
        public static void StvoriObjektPodrazumijevanimKonstruktorom()
        {
            // TODO: Stvoriti objekt klase Osoba i ispisati vrijednosti članova Ime, Prezime, 
            //DatumRođenja

            Osoba o = new Osoba();
            Console.WriteLine(o.Ime);
            Console.WriteLine(o.Prezime);
            Console.WriteLine(o.DatumRođenja);

            // TODO: U klasu Osoba dodati prazni konstruktor koji inicijalizira članove objekta 
            //na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.


        }

        public static void StvoriObjektZadanimKonstruktorom(string ime, string prezime, DateTime datumRođenja)
        {
            // TODO: U klasi Osoba promijeniti prazan konstruktor tako da prima 3 argumenta (ime, 
            //prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
            // TODO: Stvoriti objekt klase Osoba pozivom tog konstruktora i ispisati vrijednosti 
            //članova Ime, Prezime, DatumRođenja


        }


        static void Main(string[] args)
        {
            StvoriObjektPodrazumijevanimKonstruktorom();

            StvoriObjektZadanimKonstruktorom("Hrvoje", "Horvat", new DateTime(1971, 7, 4));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
