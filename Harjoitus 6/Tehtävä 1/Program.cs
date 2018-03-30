using static System.Console;

// Janne Rajuvaara
// NTK17SP 2018

namespace H6T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pari<int> pari1 = new Pari<int>() { A = 4, B = 7 };
            Pari<double> pari2 = new Pari<double>() { A = 3.6, B = 1.5 };
            Pari<string> pari3 = new Pari<string>() { A = "banaani", B = "omena" };

            WriteLine(pari1);
            WriteLine(pari2);
            WriteLine(pari3);

            ReadLine();
        }
    }
}
