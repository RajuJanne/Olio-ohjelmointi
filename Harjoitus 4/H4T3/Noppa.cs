using System;

//Janne Rajuvaara
//NTK17SP 2018

namespace H4T3
{
    class Noppa
    {
        private int _lukema, _heittoLkm;
        private double _kumulatiivinen;

        public Noppa()
        {
            _lukema = -1;
            _heittoLkm = 0;
            _kumulatiivinen = 0;
        }

        public void Heita()
        {
            Random r = new Random();
            _lukema = r.Next(1,7);
            _heittoLkm++;
            _kumulatiivinen += _lukema;
        }

        public int NaytaLukema()
        {
            return _lukema;
        }

        public int NaytaHeittojenMaara()
        {
            return _heittoLkm;
        }

        public double Kumulatiivinen()
        {
            return _kumulatiivinen;
        }
    }
}
