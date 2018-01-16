using System;
using static System.Console;

//Janne Rajuvaara - 2018
//NTK17SP

namespace Harjoitus1_tehtävä5
{
  class Program
  {
    static void Main(string[] args)
    {
      string syote;
      int koko;

      do
      {
        Write("Piirrän sinulle JouluKuusen, anna koko (vähintään 3): ");
        syote = ReadLine();
        if (TarkistaSyote(syote) is true)
        {
          koko = int.Parse(syote);
          break;
        }
      } while (true);
      JouluKuusi(koko);
      ReadKey();
    }

    static bool TarkistaSyote(string syote)
    // Tarkistetaan, että käyttäjän tarjoama syöte on numero, ja että se on suurempi tai yhtä suuri kuin 3
    {
      // tehdään temppimuuttuja parseamistestiä varten
      int temp;
      bool success = Int32.TryParse(syote, out temp);
      if (success)
      {
        if (temp < 3)
        {
          return false;
        }
        else
        {
          return true;
        }
      }
      // tämä osio suoritetaan vain jos syöte ei ollut numero
      else {
        return false;
      }
    }

    static void TulostaTyhjaa(int maara)
    {
      for (int i = 0; i < maara; i++)
      {
        Write(" ");
      }
    }

    static void TulostaTahtia(int lkm)
    {
      for (int i = 0; i < lkm; i++)
      {
        Write("*");
      }
      // Rivin tähtien tulostuksen jälkeen vaidetaan riviä
      WriteLine();
    }

    static void JouluKuusi(int koko)
    {
      //Tiedetään, että ensimmäisellä rivillä on aina yksi tähti
      //Samoin tiedetään, että jokaisella rivillä on yksi välilyönti vähemmän ja kaksi tähteä enemmän
      //Näistä voidaan päätellä, että ensimmäisellä rivillä on aina "${koko} - 1" määrä välilyöntejä
      int maara = koko - 1;
      int lkm = 1;
      for (int i = 0; i < koko; i++)
      {
        TulostaTyhjaa(maara);
        TulostaTahtia(lkm);
        maara--;
        lkm += 2;
      }
      //Tulostetaan jalka rumalla tavalla olemassaolevia metodeja käyttäen.
      for (int i = 0; i < 2; i++)
      {
        TulostaTyhjaa(koko - 2);
        TulostaTahtia(3);
      }
    }
  }
}
