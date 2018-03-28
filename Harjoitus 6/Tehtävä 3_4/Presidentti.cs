using System;

// Janne Rajuvaara
// NTK17 2018

namespace H6T3_4
{
    class Presidentti
    {
        public string Nimi { get; set; }
        public DateTime SyntymaAika { get; set; }
        public DateTime VirkaAlkuPvm { get; set; }
        public DateTime VirkaLoppuPvm { get; set; }

        public string VirkaKausi { get => $"{VirkaAlkuPvm.ToShortDateString()} - {VirkaLoppuPvm.ToShortDateString()}"; }

        public Presidentti() { }

        // #FF0000_HERRING 
        public override string ToString()
        {
            return $"{Nimi} ({VirkaAlkuPvm.Year} - {VirkaLoppuPvm.Year})";
        }
    }
}
