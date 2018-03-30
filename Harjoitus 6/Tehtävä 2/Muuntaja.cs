using System.Collections.Generic;

// Janne Rajuvaara
// NTK17SP 2018

namespace H6T2
{
    class Muuntaja
    {
        private List<Muunnos> _muunnokset;

        public Muuntaja()
        {
            _muunnokset = new List<Muunnos>();
        }

        public void LisaaMuunnos(Muunnos muunnos)
        {
            _muunnokset.Add(muunnos);
        }

        public string Muunna(string a)
        {
            foreach (Muunnos m in _muunnokset)
            {
                a = m.Muunna(a);
            }
            return a;
        }
    }
}
