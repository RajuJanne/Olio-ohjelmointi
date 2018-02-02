using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Janne Rajuvaara - 2018
//NTK17SP

namespace H2T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Syötä teksti: ");
            string merkkijono = ReadLine();
            if (OnkoPalindromi(merkkijono))
            {
                Write("On palindromi.");
            }
            else
            {
                Write("Ei ole palindromi.");
            }
            ReadLine();
        }

         static bool OnkoPalindromi(string merkkijono)
        {
            if (PoistaValimerkit(merkkijono) == Kaanna(merkkijono))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string Kaanna(string merkkijono)
        {
            string paluu = "";
            merkkijono = PoistaValimerkit(merkkijono);
            for (int i = merkkijono.Length - 1; i >= 0; i--)
            {
                paluu = paluu + merkkijono[i];
            }
            return paluu;
        }

        static string PoistaValimerkit(string merkkijono)
        {
            string paluu = "";
            char[] skipattavat = {' ', '.', ':', ';', ',', '!', '?'};

            for (int i = 0; i < merkkijono.Length; i++)
            {
                if (!skipattavat.Contains(merkkijono[i]))
                {
                    paluu = paluu + merkkijono[i];
                }
            }
            return paluu;
        }
    }
}
