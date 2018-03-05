using System;
using System.Globalization;
using static System.Console;

// Janne Rajuvaara
// NTK17SP 2018
// Epäinhimillinen versio

namespace SyntaksiSokeri
{
    public static class Syote
    {
        public static int Kokonaisluku(string kehote, int min = int.MinValue, int max = int.MaxValue)
        {
            Write(kehote);
            bool onnistuuko = int.TryParse(ReadLine(), out int kokonaisluku);
            return (onnistuuko) ? ((kokonaisluku < min || kokonaisluku > max) ? throw new Exception($"Syöte ei ole kelvollinen kokonaisluku. Minimi on {min}. Maksimi on {max}.") : kokonaisluku) : throw new Exception("Syöte ei ole kelvollinen kokonaisluku.");
        }

        public static double Desimaaliluku(string kehote, int tarkkuus = -1)
        {
            Write(kehote);
            bool onnistuuko = double.TryParse(ReadLine(), out double desimaaliluku);
            return (onnistuuko) ? (desimaaliluku = (tarkkuus > -1) ? Math.Round(desimaaliluku, tarkkuus) : desimaaliluku) : throw new Exception("Syöte ei ole kelvollinen desimaaliluku.");
        }

        public static char Merkki(string kehote)
        {
            Write(kehote);
            bool onnistuuko = char.TryParse(ReadLine(), out char merkki);
            return (onnistuuko) ? merkki : throw new Exception("Syöte ei ole kelvollinen merkki");
        }

        public static string Merkkijono(string kehote)
        {
            Write(kehote);
            string syote = ReadLine();
            return syote;
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
