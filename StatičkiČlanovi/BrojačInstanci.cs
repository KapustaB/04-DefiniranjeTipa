using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    public class BrojačInstanci
    {
        // TODO: Dodati privatni statički član "brojač" tipa int i inicijalizirati ga na 0
        private static int brojač = 0;

        // TODO: U metodu dodati naredbu koja će ispisati trenutnu vrijednost člana brojač
        public static void IspišiBrojStvorenihObjekata()
        {
            Console.WriteLine(brojač);
        }

        // TODO: U klasu dodati privatni član "instanca" tipa int
        private int instanca;

        // TODO: U konstruktor dodati naredbu koja će uvećati "brojač" za 1 i uvećanu vrijednost 
        //dodijeliti članu "instanca"
        public BrojačInstanci()
        {
            brojač++;
            instanca = brojač;
        }

        // TODO: U metodu dodati naredbu koja će ispisati vrijednost člana "instanca"
        public void IspišiRedniBrojObjekta()
        {
            Console.WriteLine(instanca);
        }
    }
}
