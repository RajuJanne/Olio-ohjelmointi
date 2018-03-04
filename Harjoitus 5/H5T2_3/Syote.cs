using System;
using System.Globalization;
using static System.Console;

// Janne Rajuvaara
// NTK17SP 2018
// H5T2_3

namespace Helpers
{
    public static class Syote
    {
        public static int Kokonaisluku(string kehote, int min = int.MinValue, int max = int.MaxValue)
        {
            Write(kehote);

            bool onnistuuko = int.TryParse(ReadLine(), out int kokonaisluku);

            if (!onnistuuko)
            {
                throw new Exception("Syöte ei ole kelvollinen kokonaisluku.");
            }
            else if (kokonaisluku < min || kokonaisluku > max)
            {
                throw new Exception($"Syöte ei ole kelvollinen kokonaisluku. Minimi on {min}. Maksimi on {max}.");
            }
            else
            {
                return kokonaisluku;
            }
        }

        public static double Desimaaliluku(string kehote, int tarkkuus = -1)
        {
            Write(kehote);

            bool onnistuuko = double.TryParse(ReadLine(), out double desimaaliluku);

            if (onnistuuko)
            {
                desimaaliluku = (tarkkuus > -1) ? Math.Round(desimaaliluku, tarkkuus) : desimaaliluku;
                return desimaaliluku;
            }
            else
            {
                throw new Exception("Syöte ei ole kelvollinen desimaaliluku.");
            }
        }

        public static char Merkki(string kehote)
        {
            Write(kehote);

            bool onnistuuko = char.TryParse(ReadLine(), out char merkki);

            if (onnistuuko)
            {
                return merkki;
            }
            else
            {
                throw new Exception("Syöte ei ole kelvollinen merkki");
            }
        }

        public static string Merkkijono(string kehote)
        {
            Write(kehote);
            return ReadLine();
            // Teknisesti ottaen täyttää tehtävänannon toiminnallisuuden.
        }

        public static DateTime Paivays(string kehote)
        {
            Write(kehote);

            // Julistetaan käyttöön CultureInfo("fi-FI"), jolloin DateTime.TryParse käyttää oletuksena tätä.
            // Tällä saavutetaan pientä etua poikkeuksien hallinnassa.
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("fi-FI");

            bool onnistuuko = DateTime.TryParse(ReadLine(), out DateTime paivays);

            return (onnistuuko) ? paivays : throw new Exception("Syöte ei ole kelvollinen päiväys.");
            // Onko tämä nyt sitä syntaksisokeria? Kirjoittajalla on likainen olo.
        }

        // Aloitetaan Tehtävä 3

        public static int KokonaislukuPakoittaen(string kehote, int min = int.MinValue, int max = int.MaxValue)
        {
            do
            {
                try
                {
                    return Kokonaisluku(kehote, min, max);
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }
            } while (true);
        }

        public static double DesimaaliPakoittaen(string kehote, int tarkkuus = -1)
        {
            do
            {
                try
                {
                    return Desimaaliluku(kehote, tarkkuus);
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }
            } while (true);
        }

        public static DateTime PaivaysPakoittaen(string kehote)
        {
            do {
                try
                {
                    return Paivays(kehote);
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }
            } while (true);
        }
    }
}
