using static System.Console;
using static Helpers2.Syote;

// Janne Rajuvaara
// NTK17SP 2018

namespace H8T2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Neliö");
            Piste nelioPiste = new Piste(KokonaislukuPakoittaen("Anna sijainnin x-koordinaatti: "), KokonaislukuPakoittaen("Anna sijainnin y-koordinaatti: "));
            Nelio nelio = new Nelio(nelioPiste, KokonaislukuPakoittaen("Anna neliön särmän pituus: "));

            WriteLine("Viiva");
            Piste viivaAlku = new Piste(KokonaislukuPakoittaen("Anna alkupisteen x-koordinaatti: "), KokonaislukuPakoittaen("Anna alkupisteen y-koordinaatti: "));
            Piste viivaLoppu = new Piste(KokonaislukuPakoittaen("Anna loppupisteen x-koordinaatti: "), KokonaislukuPakoittaen("Anna loppupisteen y-koordinaatti: "));
            Viiva viiva = new Viiva(viivaAlku, viivaLoppu);

            WriteLine($"Neliö: {nelio}");
            WriteLine($"Viiva: {viiva}");

            WriteLine("Piirretään oliot");

            nelio.Piirra();
            viiva.Piirra();

            ReadLine();
        }
    }
}
