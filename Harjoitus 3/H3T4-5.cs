using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Janne Rajuvaara - 2018
//NTK17SP


namespace H3T4_5
{
  class Program
  {
    static void Main(string[] args)
    {
      // Voit käyttää esimerkkinä henkilötunnusta 131052-308T joka löytyy väestörekisterikeskuksen esimerkistä.

      // Tämä koodi on osioitu helvetin pieniin palohin, ja asioita tehdään useampaan kertaan luettavuuden säilyttämiseksi.

      do
      {
        string kehote = "Anna henkilötunnus: ";
        try
        {
          WriteLine("Syötit henkilötunnuksen " + LueHetu(kehote) + ".");
          ReadLine();
          break;
        }
        catch (Exception e)
        {
          WriteLine(e.Message);
        }
      } while (true);
    }

    static string LueHetu(string kehote)
    {
      string tarkistettuHetu = "";
      Write(kehote);
      string syote = ReadLine();

      if (syote.Length != 11)
      {
        throw new Exception("Virhe: Henkilötunnuksen pituus on virheellinen.");
      }

      if (!TarkistaSyntyma(syote))
      {
        throw new Exception("Virhe: Syntymäaika on virheellinen");
      }

      if (!TarkisteMerkki(syote))
      {
        throw new Exception("Virhe: Virheellinen tarkistemerkki.");
      }

      if (!NumeerinenYksilo(syote))
      {
        throw new Exception("Virhe: Yksilönumero ei ole numeerinen.");
      }

      tarkistettuHetu = syote;
      return tarkistettuHetu;
    }

    static bool NumeerinenYksilo(string syote)
    {
      string tarkistenumero = syote.Substring(0, 6);
      tarkistenumero = tarkistenumero + syote.Substring(7, 3);
      bool OnkoNumero = Int32.TryParse(tarkistenumero, out int result);
      if (!OnkoNumero)
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    static bool TarkisteMerkki(string syote)
    {
      string rimpsu = syote.Substring(0, 6);
      rimpsu = rimpsu + syote.Substring(7, 3);
      int KokoNumero = int.Parse(rimpsu);
      char AnnettuMerkki = char.Parse(syote.Substring(10, 1));
      if (AnnettuMerkki != Tarkiste(KokoNumero))
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    static bool TarkistaSyntyma(string syote)
    {
      bool Onnistuiko = DateTime.TryParse(SyntymaAika(syote.Substring(0, 7)), out DateTime annettu);

      if (Onnistuiko)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    static string SyntymaAika(string syntA)
    {
      string SyntymaAika = "";
      string merkki = Vuosisata(syntA.Substring(6, 1));
      bool bpaiva = Int32.TryParse(syntA.Substring(0, 2), out int paiva);
      bool bkuu = Int32.TryParse(syntA.Substring(2, 2), out int kuu);
      bool bvuosi = Int32.TryParse(syntA.Substring(4, 2), out int vuosi);

      if (!bpaiva || !bkuu || !bvuosi)
      {
        throw new Exception("Syntymäaika on virheellinen.");
      }

      // tehdään syntymäajasta muotoa pp.kk.vvvv

      SyntymaAika = $"{paiva}.{kuu}.{merkki}{vuosi}";

      return SyntymaAika;
    }

    static string Vuosisata(string merkki)
    {
      string vuosisata = "";
      if (merkki == "+")
      {
        vuosisata = "18";
      }
      else if (merkki == "-")
      {
        vuosisata = "19";
      }
      else if (merkki == "A" || merkki == "a")
      {
        vuosisata = "20";
      }
      else
      {
        throw new Exception("Syntymäajan vuosisata on virheellinen");
      }
      return vuosisata;
    }


    static char Tarkiste(int luku)
    {
      char[] merkit = {
        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
        'A', 'B', 'C', 'D', 'E', 'F', 'H', 'J', 'K', 'L',
        'M', 'N', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y'
      };
      return merkit[luku % 31];
    }
  }
}
