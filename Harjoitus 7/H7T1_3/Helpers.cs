using System;
using System.Globalization;
using System.Linq;
using static System.Console;

// Janne Rajuvaara
// NTK17SP 2018

namespace Helpers2
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

        public static char Merkki(string kehote, char[] sallitut)
        {
            Write($"{kehote} ");
            if (!char.TryParse(ReadLine(), out char paluu))
            {
                throw new Exception("Syöte ei ole kelvollinen merkki.");
            }
            if (!sallitut.Contains(paluu))
            {
                throw new Exception($"Syöte ei ole kelvollinen merkki. Sallittuja merkkejä ovat {string.Join(",", sallitut.Select(x => x.ToString()).ToArray())}");
            }
            return paluu;
        }

        public static string Merkkijono(string kehote)
        {
            Write(kehote);
            return ReadLine();
        }

        public static string Merkkijono(string kehote, string[] sallitut, bool tasoherkkyys)
        {
            Write($"{kehote} ");
            string syote = ReadLine();
            if (tasoherkkyys == true)
            {
                return sallitut.Contains(syote) ? syote : throw new Exception($"Syöte ei ole kelvollinen merkki. Sallittuja merkkejä ovat {string.Join(",", sallitut.Select(x => x.ToString()).ToArray())}");
            }
            else
            {
                return sallitut.Contains(syote, StringComparer.OrdinalIgnoreCase) ? syote : throw new Exception($"Syöte ei ole kelvollinen merkki. Sallittuja merkkejä ovat {string.Join(",", sallitut.Select(x => x.ToString()).ToArray())}");
            }
        }

        public static DateTime Paivays(string kehote)
        {
            Write(kehote);

            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("fi-FI");

            bool onnistuuko = DateTime.TryParse(ReadLine(), out DateTime paivays);

            return (onnistuuko) ? paivays : throw new Exception("Syöte ei ole kelvollinen päiväys.");
        }


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
            do
            {
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