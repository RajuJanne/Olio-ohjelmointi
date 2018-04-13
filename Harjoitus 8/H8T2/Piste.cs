// Janne Rajuvaara
// NTK17SP 2018

namespace H8T2
{
    class Piste
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Piste(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
