using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Janne Rajuvaara
//NTK17SP

namespace H3T3
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fi-fi");
      DateTime tanaan = DateTime.Today;

      do
      {
        Write("Anna päivämäärä: ");
        string syote = ReadLine();

        try
        {
          bool onnistuuko = DateTime.TryParse(syote, out DateTime verrokki);

          if (!onnistuuko)
          {
            throw new Exception("Syöte ei ole päivämäärä.");
          }
          else
          {
            int erotus = (tanaan - verrokki).Days;
            string a = (string)tanaan.ToShortDateString();
            string b = (string)verrokki.ToShortDateString();
            WriteLine($"Päiväysten {a} ja {b} välissä on {Math.Abs(erotus)} päivää.");
            break;
          }
        }
        catch (Exception e)
        {
          WriteLine(e.Message);
        }

      } while (true);

      ReadKey();
    }
  }
}
