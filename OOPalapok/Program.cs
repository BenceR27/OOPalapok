using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Gábor";
            tanulo1.Kor = 23;

            Console.WriteLine(tanulo1);
            
        }
    }
}
