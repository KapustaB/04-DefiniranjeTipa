using System;

namespace Vsite.CSharp
{
    class Bazna
    {
        protected Bazna(int a) // konstruktor je protected!
        {
            A = a;
            Console.WriteLine(string.Format("Bazna.Bazna({0})", a));
        }

        public readonly int A;
    }

    class Izvedena // : Bazna
    {

        public readonly int B;
    }

    public class DelegiranjeKonstruktora
    {

        public static void StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(int a, int b)
        {
            // TODO: U klasu Izvedena dodati konstruktor s dva argumenta ("a" i "b") tipa int, kojima će se inicijalizirati članovi A i B. Konstruktor treba pozivati konstruktor bazne klase s jednim argumentom i proslijediti mu argument a.
            // TODO: U tijelo konstruktora dodati naredbu za ispis: Console.WriteLine(string.Format("Izvedena.Izvedena({0}, {1})", a, b));

            // TODO: Stvoriti objekt pozivom tog konstruktora:
            //Izvedena i = new Izvedena(a, b);

            // TODO: Dodati dvije naredbe koje će ispisati vrijednosti članova A i B stvorenog objekta i, pokrenuti kod i provjeriti ispis.
        }

        public static void StvoriInstancuIzvedeneKlaseKonstruktoromSJednimArgumentom(int a)
        {
            // TODO: U klasu Izvedena dodati konstruktor s jednim argumentom "a" tipa int. Taj konstruktor treba pozvati ("delegirati") prethodno definirani konstruktor klase Izvedena s dva argumenta s time da je prvi argument "a", a drugi argument je 0. 

            // TODO: U tijelo konstruktora dodati naredbu za ispis: Console.WriteLine(string.Format("Izvedena.Izvedena({0})", a));

            // TODO: Stvoriti objekt pozivom tog konstruktora:
            // Izvedena i = new Izvedena(a);

            // TODO: Dodati dvije naredbe koje će ispisati vrijednosti članova A i B stvorenog objekta i, pokrenuti kod i provjeriti ispis.
        }

        static void Main(string[] args)
        {
            StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(5, 7);
            Console.WriteLine();
            StvoriInstancuIzvedeneKlaseKonstruktoromSJednimArgumentom(5);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
