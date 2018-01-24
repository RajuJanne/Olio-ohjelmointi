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
        private enum VuodenAika
        {
            Talvi = 1,
            Kevat = 2,
            Kesa = 3,
            Syksy = 4,
            Peruna
        };


        private static void Demo1()
        {
            VuodenAika v;
            int luku;
            string syote;
            do
            {
                Write("Anna vuodenaika (1-5): ");
                syote = ReadLine();
                if (TarkistaSyote(syote) is true)
                {
                    break;
                }
            } while (true);
            luku = int.Parse(syote);
            v = (VuodenAika)luku;

            WriteLine($"Kokonaisluku {luku} on vuodenaika {v}");

        }
        static bool TarkistaSyote(string syote)
        {
            int temp;
            bool success = Int32.TryParse(syote, out temp);
            if (success)
            {
                if (temp > 5 || temp < 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
