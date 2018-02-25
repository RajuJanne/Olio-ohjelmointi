using System;
using static System.Console;

// Janne Rajuvaara
// NTK17 2018

namespace H4T1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IMachine auto1 = new HenkiloAuto();
            IMachine leikk1 = new RuohonLeikkuri();
            IMachine leko1 = new LentoKone();

            Kaynnista(auto1);
            Kaynnista(leikk1);
            Kaynnista(leko1);
            Kaynnista(leko1);
            Sammuta(auto1);
            Sammuta(leikk1);
            Sammuta(leko1);
            ReadLine();
        }
        static void Kaynnista(IStartable laite)
        {
            laite.Start();
        }
        static void Sammuta(IStoppable laite)
        {
            laite.Stop();
        }
    }
}
