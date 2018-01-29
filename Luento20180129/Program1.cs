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
            luku = double.Parse(syote);
            WriteLine("syötit luvun " + luku);
        }
    }
}
