using System;
using static System.Console;

// Janne Rajuvaara
// NTK17 2018

namespace H4T1_2
{
    class RuohonLeikkuri : IMachine
    {
        bool IStartable.Start()
        {
            System.Console.WriteLine("RuohonLeikkuri käynnistetään.");
            return true;
        }


        bool IStoppable.Stop()
        {
            System.Console.WriteLine("RuohonLeikkuri sammutettu.");
            return false;
        }
    }
}
