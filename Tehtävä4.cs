using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tehtava_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int koko;
            Write("Piirrän sinulle kolmion. Miten suuren haluat? ");
            koko = int.Parse(System.Console.ReadLine());
            WriteLine("");
            //System.Threading.Thread.Sleep(10000);
            TulostaKolmio(koko);
            ReadLine();
        }

        static void TulostaTyhjaa(int maara) {
            for (int i = 0; i < maara; i++ ) {
              Write(" ");
            }
        }

        static void TulostaTahtia(int lkm) {
            for (int i = 0; i < lkm; i++) {
              Write("*");
            }
            WriteLine("");
        }
        static void TulostaKolmio(int koko) {
           int maara = 0;
           int lkm = koko;

             for (int i = 0; i < koko; i++) {
              TulostaTyhjaa(maara);
              TulostaTahtia(lkm);
              maara++;
              lkm--;
             }
        }

    }
}
