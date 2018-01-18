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
      int korkeus;

      do
      {
        Write("Piirrän sinulle JouluKuusen, anna korkeus (vähintään 3): ");
        syote = ReadLine();

        if (TarkistaSyote(syote) is true)
        {
          korkeus = int.Parse(syote);
          break;
        }
      } while (true);
      WriteLine(); // Näyttää kivemmalta kun jätetään rivi väliä ennen kuusta
      JouluKuusi(korkeus);
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
      WriteLine();
    }

    static void JouluKuusi(int korkeus)
    {
      //Tiedetään, että ensimmäisellä rivillä on aina yksi tähti
      //Samoin tiedetään, että jokaisella rivillä on yksi välilyönti vähemmän ja kaksi tähteä enemmän
      //Näistä voidaan päätellä, että ensimmäisellä rivillä on aina "${korkeus} - 1" määrä välilyöntejä
      int maara = korkeus - 1;
      int lkm = 1;
      for (int i = 0; i < korkeus; i++)
      {
        TulostaTyhjaa(maara);
        TulostaTahtia(lkm);
        maara--;
        lkm += 2;
      }
      //Tulostetaan jalka
      for (int i = 0; i < 2; i++)
      {
        TulostaTyhjaa(korkeus - 2);
        TulostaTahtia(3);
      }
    }
  }
}
