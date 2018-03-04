using System;
using static System.Console;

//Janne Rajuvaara
//NTK17SP 2018

namespace H5T1
{
    class Opiskelija : IId, IHenkilo
    {
        static int ViimeksiKaytettyId = 0;
        private DateTime _SyntymaAika;

        public Opiskelija()
        {
            ViimeksiKaytettyId++;
            this.Id = ViimeksiKaytettyId;
        }

        public int Id { get; set; }

        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Nimi { get => $"{Etunimi} {Sukunimi}"; }

        // Jokalaista syntaksia oppimismielessä.
        public DateTime SyntymaAika { get { return _SyntymaAika; } set => _SyntymaAika = value; }

		// Seuraavassa lasketaan nykyhetken ja _SyntymaAika muuttujan erotuksesta TimeSpan olio, joka muutetaan double tyyppiseksi paivien määräksi.
		// Saatu päivien määrä jaetaan vuoden pituudella.
		// Tulos muunnetaan integeriksi, jolloin saadaan kätevästi vain täydet vuodet.
		// Vuoden pituus päivinä lähde: NASA https://pumas.jpl.nasa.gov/files/04_21_97_1.pdf
        public int Ika { get => (int)((DateTime.Now - _SyntymaAika).TotalDays / 365.2421875); }

        public override string ToString()
        {
            return Nimi;
        }

    }
}
