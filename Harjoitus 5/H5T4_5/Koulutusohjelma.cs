// Janne Rajuvaara
// NTK17SP 2018

namespace H5T4_5
{
    class Koulutusohjelma : IId, INimi
    {
        public string Nimi { get; set; }
        public int Id { get; set; }
        public string Tutkinto { get; set; }
        public int Laajuus { get; set; }
        public Oppilaitos Oppilaitos { get; set; }

        public Koulutusohjelma()
        {

        }

        public override string ToString()
        {
            return Nimi.ToString();
        }
    }
}
