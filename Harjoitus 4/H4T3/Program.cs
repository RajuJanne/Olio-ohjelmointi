using System;
using static System.Console;

//Janne Rajuvaara
//NTK17SP 2018

namespace H4T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Noppa noppa1 = new Noppa();
            noppa1.Heita();
            WriteLine("Nopan silmäluku: " + noppa1.NaytaLukema());

            do
            {
                Write("Heitetäänkö vielä (kyllä/ei)? ");
                string syote = ReadLine();
                try
                {
                    if (syote == "kyllä")
                    {
                        noppa1.Heita();
                        WriteLine("Nopan silmäluku: " + noppa1.NaytaLukema());
                    }
                    else if (syote == "ei")
                    {
                        WriteLine("Heittojen määrä on " + noppa1.NaytaHeittojenMaara());
                        WriteLine("Heittojen keskiarvo on " + noppa1.Kumulatiivinen() / noppa1.NaytaHeittojenMaara());
                        break;
                    }
                    else
                    {
                        throw new Exception("Epäkelpo syöte");
                    }
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }

            } while (true);
            ReadLine();

        }

    }
}
