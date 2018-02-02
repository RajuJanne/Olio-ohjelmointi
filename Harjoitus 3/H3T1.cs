using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Janne Rajuvaara
//NTK17SP

namespace H3T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Anna teksti: ");
            string teksti = ReadLine();
            Write("Anna kehysmerkki: ");
            char merkki = char.Parse(System.Console.ReadLine());
            TulostaKehistettyna(teksti, merkki);
            TulostaHarvasti(teksti);
            ReadLine();
        }

        static void TulostaHarvasti(string teksti)
        {
            for (int i = 0; i < teksti.Length; i++)
            {
                Write(teksti[i]);
                Write(" ");
            }
        }

        static void TulostaKehistettyna(string teksti, char merkki)
        {
            int mitta = teksti.Length;
            TulostaKehys(mitta + 4, merkki);
            WriteLine($"{merkki} {teksti} {merkki}");
            TulostaKehys(mitta + 4, merkki);
        }
        static void TulostaKehys(int mitta, char merkki)
        {
            for (int i = 0; i < mitta; i++)
            {
                Write(merkki);
            }
            WriteLine();
        }
    }
}
