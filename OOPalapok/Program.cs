using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace OOPalapok
{
    public class Szemely
    {
        private string nev;
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
        public int neptunKod;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Gábor";
            tanulo1.Kor = 23;

            Console.WriteLine(tanulo1);

            Bankszamla bankszamla1 = new Bankszamla();
            bankszamla1.Egyenleg = -23000;
            Console.WriteLine(bankszamla1.Egyenleg);
            
        }
    }
}
