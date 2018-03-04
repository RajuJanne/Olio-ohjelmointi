using static System.Console;

// Janne Rajuvaara
// NTK17SP 2018

namespace H5T4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Oppilaitos ol1 = TeeOppilaitos();
            Koulutusohjelma ko1 = TeeKoulutusohjelma();
            Koulutusohjelma ko2 = TeeKoulutusohjelma();
            ko1.Oppilaitos = ol1;
            ko2.Oppilaitos = ol1;

            TulostaKoulutusohjelma(ko1);
            TulostaKoulutusohjelma(ko2);

            ReadLine();
        }
        static Oppilaitos TeeOppilaitos()
        {
            Oppilaitos oppilaitos = new Oppilaitos();
            oppilaitos.Id = Helpers.Syote.KokonaislukuPakoittaen("Anna oppilaitoksen id: ",0);
            oppilaitos.Nimi = Helpers.Syote.Merkkijono("Anna oppilaitoksen nimi: ");

            return oppilaitos;
        }
        static Koulutusohjelma TeeKoulutusohjelma()
        {
            Koulutusohjelma koulutusohjelma = new Koulutusohjelma();
            koulutusohjelma.Id = Helpers.Syote.KokonaislukuPakoittaen("Anna koulutusohjelman id: ",0);
            koulutusohjelma.Nimi = Helpers.Syote.Merkkijono("Anna tutkinnon nimi: ");
            koulutusohjelma.Laajuus = Helpers.Syote.KokonaislukuPakoittaen("Anna tutkinnon laajuus: ",0);
            koulutusohjelma.Tutkinto = Helpers.Syote.Merkkijono("Anna tutkinnon nimi: ");

            return koulutusohjelma;
        }
        static void TulostaKoulutusohjelma(Koulutusohjelma koulutusohjelma)
        {
            WriteLine($"{koulutusohjelma.Oppilaitos.Nimi}, {koulutusohjelma.Nimi} {koulutusohjelma.Laajuus} op ({koulutusohjelma.Tutkinto})");
        }
    }
}
