// Janne Rajuvaara
// NTK17SP 2018

namespace H6T1
{
    class Pari<T> : IPari<T>
    {
        private T _A;
        private T _B;

        public T A { get; set; }
        public T B { get; set; }

        public Pari(T a, T b)
        {
            _A = a;
            _B = b;
        }
        public Pari()
        {
            _A = default(T);
            _B = default(T);
        }

        public override string ToString()
        {
            return $"{A}, {B}";
        }
    }
}
