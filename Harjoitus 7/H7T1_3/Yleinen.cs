using System;
using System.Collections.Generic;
using System.Globalization;

// Janne Rajuvaara
// NTK17SP 2018

namespace Helpers2
{
    public class Yleinen
    {
        public static T Maksimi<T>(T eka, T toka) where T : IComparable<T>
        { 
            int i = eka.CompareTo(toka);
            
            if (i == 1)
            {
                return eka;
            }
            else if (i == -1)
            {
                return toka;
            }
            else
            {
                throw new Exception("Yhtä suuret");
            }
        }
        public static T Minimi<T>(T eka, T toka) where T : IComparable<T>
        {
            int i = eka.CompareTo(toka);
            if (i == 1)
            {
                return toka;
            }
            else if (i == -1)
            {
                return eka;
            }
            else
            {
                throw new Exception("Yhtä suuret");
            }
        }
        public T Uusi<T>() where T : new()
        {
            return new T();
        }
        public List<T> UusiAlustettuLista<T>(T olio, int lkm = 1) where T : new()
        {
            List<T> UusiLista = new List<T>();
            for (int i = 0; i < lkm; i++)
            {
                UusiLista.Add(new T());
            }
            return UusiLista;
        }

        private static Viikko TeeViikko(int vuosi, int nro, DateTime alku)
        {
            Viikko viikko = new Viikko(nro, vuosi);
            for (int i = 0; i < 7; i++)
            {
                viikko.Paivat[i] = alku.AddDays(i);
            }
            return viikko;
        }

        public static Viikko[] VuodenViikot(int vuosi)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fi-FI");

            List<Viikko> VuodenViikot = new List<Viikko>();

            DateTime alku = new DateTime(vuosi, 1, 1);

            // Koska FirstDayOfWeek haluaa uppiniskaisesti käyttää DayOfWeek.Sunday, käytämme me matematiikkaa päihittämään perkeleen.
            int ekaPaiva = (int)(alku.DayOfWeek + 6) % 7;
            DateTime ensimmainenMaanantai;

            if (ekaPaiva <= 3)
            {
                ensimmainenMaanantai = alku.AddDays(ekaPaiva * -1);
            }
            else
            {
                ensimmainenMaanantai = alku.AddDays(7 - ekaPaiva);
            }

            for (int i = 0; i < 51; i++)
            {
                VuodenViikot.Add(TeeViikko(vuosi, i + 1, ensimmainenMaanantai.AddDays(i * 7)));

                if (i == 51)
                {
                    if (ensimmainenMaanantai.AddDays(((i+1) * 7) + 4).Year == vuosi)
                    {
                        VuodenViikot.Add(TeeViikko(vuosi, i + 2, ensimmainenMaanantai.AddDays((i+1) * 7)));
                    }
                }
            }

            return VuodenViikot.ToArray();
        }
    }
}
