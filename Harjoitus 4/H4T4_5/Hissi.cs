using static System.Console;

// Janne Rajuvaara
// NTK17SP 2018

namespace H4T4_5
{
    class Hissi
    {
        // THE FIELD 'Hissi._ovetAuki' IS ASSIGNED BUT ITS VALUE IS NEVER USED >:((((
        private bool _ovetAuki;
        private int _kerros, _maxKerros;

        public Hissi(int kerroksia)
        {
            _maxKerros = kerroksia;
            _ovetAuki = false;
            _kerros = 1;
        }

        public void Siirry(int kerros)
        {
            if (kerros > _kerros)
            {
                SiirryYlos(kerros);
            }
            else
            {
                SiirryAlas(kerros);
            }
        }

        private void SiirryYlos(int kerros)
        {
            SuljeOvet();
            while (kerros > _kerros && kerros <= _maxKerros && kerros > 0)
            {
                _kerros++;
                NaytaKerrokset();
            } 
            AvaaOvet();
        }

        private void SiirryAlas(int kerros)
        {
            SuljeOvet();
            while (kerros < _kerros && kerros <= _maxKerros && kerros > 0)
            {
                _kerros--;
                NaytaKerrokset();
            }
            AvaaOvet(); 
        }

        private void AvaaOvet()
        {
            _ovetAuki = true;
            WriteLine("Ovet ovat auki.");
        }

        private void SuljeOvet()
        {
            _ovetAuki = false;
            WriteLine("Ovet ovat kiinni.");
        }

        public void NaytaKerrokset()
        {
            for (int i = 1; i <= _maxKerros; i++)
            {
                if (i == _kerros)
                {
                    Write($"[{i}] ");
                }
                else
                {
                    Write(i + " ");
                }               
            }
            WriteLine();
        }
    }
}
