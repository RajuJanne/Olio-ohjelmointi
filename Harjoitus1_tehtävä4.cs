using System;
using static System.Console;

//Janne Rajuvaara - 2018
//NTK17SP

namespace Tehtava_4
{
  class Program
  {
    static void Main(string[] args)
    {
      int koko;
      Write("Piirrän sinulle kolmion. Miten suuren haluat? ");
      koko = int.Parse(System.Console.ReadLine());
      WriteLine("");
      TulostaKolmio(koko);
      // pyydetään käyttäjältä syöte,
      // jotta konsoli pysyy auki tulostuksen jälkeen
      ReadLine();
    }

    static void TulostaTyhjaa(int maara) {
      // Tämä metodi on kirjaimellisesti tyhjäntoimittaja.
      for (int i = 0; i < maara; i++ ) {
        Write(" ");
      }
    }

    static void TulostaTahtia(int lkm) {
      for (int i = 0; i < lkm; i++) {
        Write("*");
      }
      WriteLine(""); //Tähtiä seuraa aina rivinvaihto
    }
    static void TulostaKolmio(int koko) {
      // Tiedetään, että ensimmäisellä rivillä on 0 tyhjää
      // ja tähtien määrä == koko
      int maara = 0;
      int lkm = koko;

      for (int i = 0; i < koko; i++) {
        TulostaTyhjaa(maara);
        TulostaTahtia(lkm);
        maara++;
        lkm--;
      }
    }
  }
}
