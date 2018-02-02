using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Janne Rajuvaara - 2018
//NTK17SP

namespace H2T2
{
    class Program
    {

        static void Main(string[] args)
        {
            long pitka;
            Write("Anna pitkä luku: ");
            pitka = long.Parse(ReadLine());
            TulostaOnnistuuko(pitka);
            ReadLine();
        }

        static void TulostaOnnistuuko(long pitka)
        {
            int tulos;
            if (LongToInt(pitka, out tulos))
            {
                WriteLine($"{pitka} (long) --> {tulos} (int)");
            }
            else
            {
                WriteLine($"Lukua {pitka} ei voi muuttaa int-luvuksi");
            }
        }

        static bool LongToInt(long pitka, out int tulos)
        {
            bool onnistuu;
            int viite;
            if (pitka > int.MaxValue || pitka < int.MinValue)
            {
                onnistuu = false;
                viite = 0;
            }
            else
            {
                viite = (int)pitka;
                onnistuu = true;
            }
            tulos = viite;
            return onnistuu;
        }
    }
}
