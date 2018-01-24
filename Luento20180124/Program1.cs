using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Janne Rajuvaara - 2018
//NTK17SP

namespace Luento20180124
{
    class Program
    {
        static void Main(string[] args) {
            Demo1();
            ReadLine();
        }
        enum VuodenAika
        {
            Talvi = 1,
            Kevat = 2,
            Kesa = 3,
            Syksy = 4,
            Peruna,
            // saa automaattisesti numeron 5.
        }


        private static void Demo1()
        {
            VuodenAika v;
            int luku;
            Write("Anna vuodenaika (1-5): ");
            luku = int.Parse(ReadLine());

            v = (VuodenAika)luku;

            WriteLine($"Kokonaisluku {luku} on vuodenaika {v}");

        }
    }
}
