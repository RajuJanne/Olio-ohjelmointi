using System;
using static System.Console;

// Janne Rajuvaara
// NTK17 2018

namespace H4T1_2
{
    class LentoKone : IMachine
    {
        private IMachine _moottori1;
        private IMachine _moottori2;

        public LentoKone()
        {
            _moottori1 = new LentoKoneMoottori();
            _moottori2 = new LentoKoneMoottori();
        }

        public bool Start()
        {
            WriteLine("Moottori 1 käynnistetään.");
            bool m1 = _moottori1.Start();
            WriteLine("Moottori 2 käynnistetään.");
            bool m2 = _moottori2.Start();
            return (m1 && m2);
        }

        public bool Stop()
        {
            WriteLine("Moottori 1 sammutetaan.");
            bool m1 = _moottori1.Stop();
            WriteLine("Moottori 2 sammutetaan.");
            bool m2 = _moottori2.Stop();
            return (m1 && m2);
        }
    }
}
