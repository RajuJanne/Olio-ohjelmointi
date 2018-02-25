using System;
using static System.Console;

// Janne Rajuvaara
// NTK17 2018

namespace H4T1_2
{
    class LentoKoneMoottori : IMachine
    {
        private bool _started;

        public bool Start()
        {
            if (_started == false)
            {
                _started = true;
                WriteLine("LentoKoneMoottori käynnistetty.");
            }
            else
            {
                WriteLine("Ei käynnistetty, koska LentoKoneMoottori on jo käynnissä.");
            }
            return _started;
        }

        public bool Stop()
        {
            if (_started == true)
            {
                _started = false;
                WriteLine("LentoKoneMoottori sammutettu.");
            }
            else
            {
                WriteLine("Ei sammutettu, koska LentoKoneMoottori ei ole käynnissä.");
            }
            return !_started;
        }
    }
}
