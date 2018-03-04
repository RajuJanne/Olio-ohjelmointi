// Janne Rajuvaara
// NTK17SP 2018

namespace H5T4_5
{
    class Oppilaitos : IId, INimi
    {
        public int Id { get; set; }
        public string Nimi { get; set; }

        // Unless the class is static, classes without constructors are given a public default constructor by the C# compiler in order to enable class instantiation.
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-constructors
        // Laitetaan nyt silti, kun tehtävänanto sen pyytää.
        public Oppilaitos()
        {
        }

        public override string ToString()
        {
            return Nimi.ToString();
        }
    }
}
