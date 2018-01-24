using System;
using static System.Console;

//Janne Rajuvaara - 2018
//NTK17SP

namespace Luento20180124
{
    class Program
    {
        static void Main(string[] args)
        {
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
            int luku = 0;
            do
            {
                Write("Anna vuodenaika (1-5): ");
                try
                {
                    luku = int.Parse(ReadLine());
                }
                catch (Exception e)
                {
                    WriteLine($"Virheellinen syöte. {e.Message}");
                    luku = 0;
                }

                if (luku >=1 && luku <= 5)
                {
                    v = (VuodenAika)luku;
                }
                else
                {
                    Write("Anna se numero ny saatana, 1 - 5: ");
                    luku = int.Parse(ReadLine());
                }

            } while (luku < 1 || luku > 5);
            v = (VuodenAika)luku;

            WriteLine($"Kokonaisluku {luku} on vuodenaika {v}");

        }
    }
}
