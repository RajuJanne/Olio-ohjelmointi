using System;
using static System.Console;

// Janne Rajuvaara
// NTK17 2018

namespace H4T1_2
{
    class HenkiloAuto : IMachine
    {

        bool IStartable.Start()
        {
            System.Console.WriteLine("HenkiloAuto käynnistetään.");
            return true;
        }

        bool IStoppable.Stop()
        {
            System.Console.WriteLine("HenkiloAuto sammutettu.");
            return false;
        }
    }
}
