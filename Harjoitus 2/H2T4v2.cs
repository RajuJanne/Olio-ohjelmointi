using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Janne Rajuvaara - 2018
//NTK17SP

namespace H2T4v2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fi-fi");
            WriteLine("Anna päivämäärä: ");
            string syote = ReadLine();
            DateTime paivamaara = DateTime.Parse(syote);

            WriteLine("Päivämäärä eroteltuna: ");
            WriteLine("Päivä: " + paivamaara.Day);
            WriteLine("Kuukausi: " + paivamaara.Month);
            WriteLine("Vuosi: " + paivamaara.Year);

            ReadLine();
        }
    }
}
