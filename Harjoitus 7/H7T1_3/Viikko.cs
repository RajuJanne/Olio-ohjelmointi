using System;

// Janne Rajuvaara
// NTK17SP 2018

namespace Helpers2
{
    public class Viikko
    {
        public int Vuosi { get; set; }
        public int Numero { get; set; }
        public DateTime[] Paivat { get; set; }

        public Viikko(int nro, int vuosi)
        {
            Vuosi = vuosi;
            Numero = nro;
            Paivat = new DateTime[7];
        }
    }
}