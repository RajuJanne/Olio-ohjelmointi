// Janne Rajuvaara
// NTK17SP 2018

namespace H6T2
{
    class Muunnos
    {
        private char _muunnettava;
        private char _muunnettu;

        public Muunnos(char muunnettava, char muunnettu)
        {
            _muunnettava = muunnettava;
            _muunnettu = muunnettu;
        }

        public string Muunna(string a)
        {
            return a.Replace(_muunnettava, _muunnettu);
        }
    }
}
