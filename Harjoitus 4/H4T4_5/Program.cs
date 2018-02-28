using static System.Console;

// Janne Rajuvaara
// NTK17SP 2018

namespace H4T4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Anna hissin kerrosten määrä: ");
            int kerros, kerrokset = int.Parse(ReadLine());

            Hissi hissi1 = new Hissi(kerrokset);
            hissi1.NaytaKerrokset();

            do
            {
                Write("Anna kerros: ");
                kerros = int.Parse(ReadLine());
                hissi1.Siirry(kerros);
            } while (kerros != 1) ;

            ReadLine();
        }
    }
}
