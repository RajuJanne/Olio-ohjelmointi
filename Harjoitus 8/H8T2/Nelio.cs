using static System.Console;

// Janne Rajuvaara
// NTK17SP 2018

namespace H8T2
{
    class Nelio : PiirtoElementti
    {
        public int Sarma { get; set; }

        public Nelio(Piste sijainti, int sarma) : base(sijainti)
        {
            Sarma = sarma;
        }

        public override string ToString()
        {
            return $"sijainti: {base.ToString()}, sivun pituus: {Sarma}";
        }

        public override void Piirra()
        {
            WriteLine("Piirretään Neliö ...");
        }
    }
}
