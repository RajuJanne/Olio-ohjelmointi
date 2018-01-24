using System;
using System.Globalization;
using static System.Console;

namespace Luento20180122
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            OmaLuokka ol = new OmaLuokka();
            string teksti = "kissa";
            ol.AsetaId(1);

            // Arvotyyppi
            WriteLine(x);
            KasvataLuku(x,5);
            WriteLine(x);

            // Viitetyyppi
            WriteLine(ol.Id);
            MuutaOliota(ol, 2);
            WriteLine(ol.Id);

            // Viitetyyppi joka on muuttumaton (immutable)
            WriteLine(teksti);
            MuutaTeksti(teksti, "koira");
            WriteLine(teksti);

            // Arvotyyppi vaihdetaan viitetyypiksi
            WriteLine(x);
            KasvataLuku2(ref x, 5);
            WriteLine(x);

            ReadLine();
        }

        private static void MuutaTeksti(string teksti, string uusi)
        {
            teksti = uusi;
        }

        static void MuutaOliota(OmaLuokka olio, int uusi)
        {
            olio.AsetaId(uusi);
        }

        static void KasvataLuku(int x, int kasvatus)
        {
            x = x + kasvatus;
        }

        static void KasvataLuku2(ref int x, int kasvatus)
        {
            x = x + kasvatus;
        }
    }
}
