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

            try
            {
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
            catch (Exception e)
            {
                WriteLine(e.Message);
                throw e;
            }
        }

        public static double Desimaaliluku(string kehote, int tarkkuus = -1)
        {
            Write(kehote);

            bool onnistuuko = double.TryParse(ReadLine(), out double desimaaliluku);

            try
            {
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
            catch (Exception e)
            {
                WriteLine(e.Message);
                throw e;
            }
        }

        public static char Merkki(string kehote)
        {
            Write(kehote);

            bool onnistuuko = char.TryParse(ReadLine(), out char merkki);

            try
            {
                if (onnistuuko)
                {
                    return merkki;
                }
                else
                {
                    throw new Exception("Syöte ei ole kelvollinen merkki");
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                throw e;
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

            try
            {
                return (onnistuuko) ? paivays : throw new Exception("Syöte ei ole kelvollinen päiväys.");
                // Onko tämä nyt sitä syntaksisokeria? Kirjoittajalla on likainen olo.
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                throw e;
            }
        }

        // Aloitetaan Tehtävä 3

        public static int KokonaislukuPakoittaen(string kehote, int min = int.MinValue, int max = int.MaxValue)
        {
            do
            {
                // return lopettaa metodin suorittamisen, joten sitä voidaan efektiivisesti käyttää break komentona.
                return Kokonaisluku(kehote, min, max);
                // Tällä tasolla ei ole varsinaisesti mitään syytä implementoida vikasietoisuutta, sillä se on jo 
                // tehty Kokonaisluku-metodissa.
            } while (true);
        }

        public static double DesimaaliPakoittaen(string kehote, int tarkkuus = -1)
        {
            do { return Desimaaliluku(kehote, tarkkuus); } while (true);
        }

        public static DateTime PaivaysPakoittaen(string kehote)
        {
            do { return Paivays(kehote); } while (true);
        }
    }
}
