using System;
using static System.Console;

//Janne Rajuvaara
//NTK17SP 2018

namespace H5T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija1 = new Opiskelija() { Etunimi = "Olli", Sukunimi = "Oppija", SyntymaAika = new DateTime(1995,03,25) }, 
                       opiskelija2 = new Opiskelija() { Etunimi = "Maria", Sukunimi = "Malli", SyntymaAika = new DateTime(1996,11,2) };

            WriteLine($"{opiskelija1.Id} {opiskelija1.Nimi}, {opiskelija1.Ika}" +
                    $"\n{opiskelija2.Id} {opiskelija2.Nimi}, {opiskelija2.Ika}");

            ReadLine();

        }
    }
}
