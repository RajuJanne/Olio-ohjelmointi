using static System.Console;

// Janne Rajuvaara
// NTK17SP 2018

namespace H6T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Muuntaja deskandinaattori = new Muuntaja();

            deskandinaattori.LisaaMuunnos(new Muunnos('ä', 'a'));
            deskandinaattori.LisaaMuunnos(new Muunnos('Ä', 'A'));
            deskandinaattori.LisaaMuunnos(new Muunnos('å', 'a'));
            deskandinaattori.LisaaMuunnos(new Muunnos('Å', 'A'));
            deskandinaattori.LisaaMuunnos(new Muunnos('ö', 'o'));
            deskandinaattori.LisaaMuunnos(new Muunnos('Ö', 'O'));

            Write("Anna teksti: ");
            string syote = ReadLine();
            WriteLine("Skandit pois: " + deskandinaattori.Muunna(syote));
            ReadLine();
        }
    }
}
