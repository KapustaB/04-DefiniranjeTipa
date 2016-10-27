using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        // TODO: Dodati privatno polje (podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5

        int broj = 5;
        // TODO: U metodu IspišiČlan dodati naredbu koja će ispisati podatkovni član "broj".
        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }
    }


    struct MojaStruktura
    {
        // TODO: Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost 
        //"MojaStruktura"
        private string tekst;// = "MojaStruktura";

        public MojaStruktura(string tekst)
        {
            this.tekst = tekst;
        }
        // TODO: U metodu IspišiČlan dodati naredbu koja će ispisati podatkovni član "tekst".
        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }
    }


    public class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            MojaKlasa mk = new MojaKlasa();
            mk.IspišiČlan();
            // TODO: Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu IspišiČlan

        }

        public static void IspišiČlanStrukture()
        {
            // TODO: Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan koja treba ispisati "MojaStruktura".
            MojaStruktura ms = new MojaStruktura("MojaStruktura");
            ms.IspišiČlan();
        }

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
