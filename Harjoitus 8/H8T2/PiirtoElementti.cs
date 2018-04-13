using static System.Console;

// Janne Rajuvaara
// NTK17SP 2018

namespace H8T2
{
    class PiirtoElementti
    {
        public Piste Sijainti { get; set; }

        public PiirtoElementti(Piste sijainti)
        {
            Sijainti = sijainti;
        }

        public override string ToString()
        {
            return $"({Sijainti.X}, {Sijainti.Y})";
        }

        public virtual void Piirra()
        {
            WriteLine("Piirretään PiirtoElementti ...");
        }
    }
}
