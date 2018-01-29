using System;
using static System.Console;

//Janne Rajuvaara - 2018
//NTK17SP

namespace L0129
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Demo");

            try
            {
                Metodi1();
            }
            catch (Exception e)
            {
                //  WriteLine("Jotain meni pieleen.");
                WriteLine(e.Message);
            }


            ReadLine();
        }

        static void Metodi1()
        {
            string syote;
            double luku;
            Write("Anna desimaaliluku [-100,100]: ");
            syote = ReadLine();
            //bool success = Double.TryParse(syote, out luku);
            try
            {
                luku = double.Parse(syote);
                if (luku < -100 || luku > 100)
                {
                    throw new ApplicationException("Luku ei ole parametrien rajoissa.");
                }

                WriteLine("syötit luvun " + luku);
            }
            catch (FormatException)
            {
                WriteLine("Annoit paskan syötteen vammane.");
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
            finally
            {
              WriteLine("Käsittely päättynyt.");
            }
        }
    }
}
