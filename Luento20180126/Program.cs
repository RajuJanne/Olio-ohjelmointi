using System;
using static System.Console;

namespace Luento20180126
{
    class Program
    {
        static void Main(string[] args)
        {
            int lkm;

            Write("Anna luku:");
            lkm = int.Parse(ReadLine());

            TulostaPaivat(lkm);

            ReadLine();
        }

        static void TulostaPaivat(int lkm)
        {
            DateTime pvm;
            pvm = DateTime.Today;

            for (int i = 0; i < lkm; i++)
            {
                WriteLine(pvm.AddDays(i).ToShortDateString());
            }
            
        }
        static bool OnJaollinen(int jaettava, int jakaja)
        {
            return jaettava % jakaja == 0;
        }
    }
}
