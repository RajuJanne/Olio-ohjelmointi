using static System.Console;

// Janne Rajuvaara
// NTK17SP 2018

namespace H8T2
{
    class Viiva : PiirtoElementti
    {
        public Piste LoppuPiste { get; set; }

        public Viiva(Piste alkupiste, Piste loppupiste) : base(alkupiste)
        {
            LoppuPiste = loppupiste;
        }

        public override void Piirra()
        {
            WriteLine("Piirretään Viiva ...");
        }

        public override string ToString()
        {
            return $"alkupiste {Sijainti.ToString()}, loppupiste: {LoppuPiste.ToString()}";
        }
    }
}
