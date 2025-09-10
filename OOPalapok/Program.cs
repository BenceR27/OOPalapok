using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPalapok
{
    public class Szemely
    {
        public string nev;
        public int kor;

        public string Nev
        {
            get { return nev; } 
            set { nev = value; }
        }

        public int Kor
        {
            get { return kor; }
            set 
            { 
                if (value < 0)
                {
                    kor = 0;
                }
                else
                {
                    kor = value; 
                }
            }
        }
        /*public Szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
        }

        public string Kiir()
        {
            return $"A tanulo neve: {nev} és {kor} éves";
        }*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Gábor";
            Console.WriteLine(tanulo1.Nev);
            tanulo1.Kor = 23;
            Console.WriteLine(tanulo1.Kor);

            /*Szemely tanulo1 = new Szemely("Jani", 55);
            Console.WriteLine(tanulo1.Kiir());
            Szemely tanulo2 = new Szemely("Feri", 45);
            Console.WriteLine(tanulo2.Kiir());*/
        }
    }
}
