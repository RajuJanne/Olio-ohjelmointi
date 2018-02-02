using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Janne Rajuvaara - 2018
//NTK17SP

namespace H2T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Anna päivämäärä: ");
            string paivamaara = ReadLine();

            int eka = paivamaara.IndexOf(".");
            int toka = paivamaara.LastIndexOf(".");
            int indexmitta = paivamaara.Length;

            string paiva = paivamaara.Substring(0, eka);
            string kuukausi = paivamaara.Substring(eka + 1, toka - eka -1);
            string vuosi = paivamaara.Substring(toka + 1, indexmitta - toka -1);

            WriteLine($"vuosi = {vuosi}");
            WriteLine($"kuukausi = {kuukausi}");
            WriteLine($"päivä = {paiva}");
            ReadLine();
        }
    }
}
