using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    public class Szemely
    {
        protected string nev;
        protected int kor;

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
            return $"A személy neve {nev} és életkora {kor}";
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
                if (value >= 0)
                {
                    egyenleg = value;
                }
                else
                {
                    Console.WriteLine("Az érték nem lehet negatív.");
                }
            }
        }
        public void betesz()
        {

        }
        public void kivesz()
        {

        }
    }
    public class Hallgato : Szemely
    {
        private string neptunkod;

        public string Neptunkod
        {
            get { return neptunkod; }
            set 
            {
                if (value.Length <= 6)
                {
                    neptunkod = value;
                }
                else 
                {
                    Console.WriteLine("Nem megfelelő hosszúság");
                }
            }
        }
        public void kiir()
        {
            nev = string.Empty;
        }
    }
    public class Dolgozo : Szemely
    {
        private int Ber;


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Gábor";
            tanulo1.Kor = 23;

            Console.WriteLine(tanulo1);
            Console.WriteLine("---------------------------------------");
            Bankszamla bankszamla1 = new Bankszamla();
            bankszamla1.Egyenleg = 5700;
            Console.WriteLine(bankszamla1.Egyenleg);
            Console.WriteLine("---------------------------------------");
            Hallgato hallgato1 = new Hallgato();
            hallgato1.Neptunkod = "MHWLN9";
            Console.WriteLine($"{hallgato1.Neptunkod}");
            Console.WriteLine("---------------------------------------");
            List<Hallgato> hallgatok = new List<Hallgato>();

            for (int i = 0; i < 2; i++)
            {
                Hallgato hallgato = new Hallgato();
                Console.WriteLine($"Kérem az {i + 1} hallgato nevét");
                hallgato.Nev = Console.ReadLine();
                Console.WriteLine($"Kérem az {i + 1} hallgato életkorát");
                hallgato.Kor = int.Parse(Console.ReadLine());
                Console.WriteLine($"Kérem az {i + 1} hallgato neptunkódját");
                hallgato.Neptunkod = Console.ReadLine();
                hallgatok.Add(hallgato);
            }
            Console.WriteLine("Hallgatók neve: ");
            foreach (var item in hallgatok)
            {
                Console.WriteLine($"A hallgatók neve: {item.Nev}");
            }
            Console.WriteLine("---------------------------------------");
        }
    }
}