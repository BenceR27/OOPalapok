using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace OOPalapok
{
    public class Szemely
    {
        protected string nev;
        public int kor;

        public string Nev
        {
            get { return nev; } 
            set { nev = value; }
        }

        public int Kor
        {
            get { return kor; }
            set { kor = value; }
        }

        public override string ToString()
        {
            return $"A személy neve {nev}, életkora {kor}";
        }
    }

    public class Bankszamla
    {
        private int egyenleg;

        public int Egyenleg
        {
            get { return egyenleg; }
            set 
            { 
                if(value >=  0)
                egyenleg = value;
                else
                    Console.WriteLine("Az érték nem lehet negatív. ");
            }
        }

        public void Betesz()
        {

        }
        
        public void Kivesz()
        {

        }
    }

    public class Hallgato : Szemely
    {
        private string neptunKod;

        public string NeptunKod
        {
            get { return neptunKod; }
            set 
            {
                if (value.Length <= 6)
                    neptunKod = value;
                else
                    Console.WriteLine("Nem megfelelő hosszúság."); 
            }
        }

        public void Kiir()
        {
            nev = string.Empty;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Gábor";
            tanulo1.Kor = 23;
            Console.WriteLine(tanulo1);

            Console.WriteLine("---------------------");

            Bankszamla bankszamla1 = new Bankszamla();
            bankszamla1.Egyenleg = 23000;
            Console.WriteLine(bankszamla1.Egyenleg);

            Console.WriteLine("---------------------");

            Hallgato hallgato1 = new Hallgato();
            hallgato1.NeptunKod = "RIZZ27";
            Console.WriteLine(hallgato1.NeptunKod);

            Console.WriteLine("---------------------");

            List<Hallgato> hallgatok = new List<Hallgato>();

            for (int i = 0; i < 2; i++)
            {
                Hallgato hallgato = new Hallgato();
                Console.Write($"Kérem a(z) {i + 1} hallgató nevét: ");
                hallgato.Nev = Console.ReadLine();
                Console.Write($"Kérem a(z) {i + 1} hallgató életkorát: ");
                hallgato.Kor = int.Parse( Console.ReadLine() );
                Console.Write($"Kérem a(z) {i + 1} hallgató neptun kódját: ");
                hallgato.NeptunKod = Console.ReadLine();
                hallgatok.Add( hallgato );
            }
            Console.WriteLine("Hallgatók neve: ");
            foreach (var item in hallgatok)
            {
                Console.WriteLine(item.Nev);
            }

            Console.WriteLine("---------------------");
        }
    }
}
