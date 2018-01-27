using System;
using static System.Console;

//Janne Rajuvaara - 2018
//NTK17SP

namespace yourNamespace
{
  class Program
  {
    static void Main(string[] args)
    {
      Demo1();

      ReadLine();
    }

    static void Demo1() {
      //Harjoitus2 tehtävä3
      string teksti;
      Write("Anna teksti: ");
      teksti = ReadLine();

      WriteLine(Kaanna(teksti));
    }

    static string Kaanna(string teksti)
    {
      string paluu = ""; // tyhjä joukko kek
      for (int i = teksti.Length - 1; i >= 0; i--) {
        // stringin pituus lähtee ykkösestä, stringin yksittäisen merkin indeksi lähtee nollasta
        paluu = paluu + teksti[i];
      }
      return paluu;
    }
  }
}
