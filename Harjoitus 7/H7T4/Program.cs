using static System.Console;
using Helpers2;
using System.Globalization;
using System;

// Janne Rajuvaara
// NTK17SP 2018

namespace H7T4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fi-FI");

            int vuosi = Syote.KokonaislukuPakoittaen("Anna vuosiluku: ", 1, 3000);
            int nro = Syote.KokonaislukuPakoittaen("Anna aloitusviikko: ", 1, 52);
            int lkm = Syote.KokonaislukuPakoittaen("Anna viikkojen määrä: ", 1, 53);

            Viikko[] viikot = TeeViikot(nro, vuosi, lkm);

            for (int i = 0; i < lkm; i++)
            {
                WriteLine($"Viikko {nro + i} [{viikot[i].Paivat[0].ToShortDateString()} - {viikot[i].Paivat[6].ToShortDateString()}]");
            }

            ReadLine();
        }

        static Viikko[] TeeViikot(int nro, int vuosi, int lkm)
        {
            Viikko[] viikot = new Viikko[lkm];
            Array.Copy(Yleinen.VuodenViikot(vuosi), (nro - 1), viikot, 0, lkm);
            return viikot;
        }
    }
}
