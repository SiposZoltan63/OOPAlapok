using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    public class Szemely
    {
        private string nev;
        private int kor;

        public Szemely(string Nev,int Kor)
        {
            nev = Nev;
            kor = Kor;
        }

        public string kiir()
        {
           return $"A tanuló neve: {nev} és {kor} éves.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely("Jani",55);
            Console.WriteLine(tanulo1.kiir());
            Szemely tanulo2 = new Szemely("Zoli", 18);
            Console.WriteLine(tanulo2.kiir());
        }
    }
}
