using System;
using static System.Console;

namespace H2T1
{
    class Program
    {
        static void Main(string[] args)
        {
            //tehtävänanto on tässä
            int x = -20;
            long y = 30L;
            double d = 4.98;
            string s = "kissa";
            char c = 'a';
            bool b = false;
            object o = null;
            DateTime t = new DateTime(1917, 12, 6);
            Random r = new Random();


            Write("Anna alakohta(a - l): ");
            string valinta = ReadLine();

            if (valinta == "a")
            {
                x = (int)y; // Long ei mene intiin ilman muunnosta
                WriteLine(x);
            }
            else if (valinta == "b")
            {
                y = (long)d; // y == 4
                WriteLine(y);
            }
            else if (valinta == "c")
            {
                d = x;
                WriteLine(d);
            }
            else if (valinta == "d")
            {
                x = c;
                WriteLine(x);
            }
            else if (valinta == "e")
            {
                //s = $"{x}"; // lul?
                s = x.ToString();
                WriteLine(s);
            }
            else if (valinta == "f")
            {
                x = int.Parse(s); // string ei mene intiin ilman muunnosta
                WriteLine(x);
            }
            else if (valinta == "g")
            {
                b = x > y;
                WriteLine(b);
            }
            else if (valinta == "h")
            {
                s = $"{t}"; //
                WriteLine(s);
            }
            else if (valinta == "i")
            {
                o = t;
                WriteLine(o);
            }
            else if (valinta == "j")
            {
                o = x;
                WriteLine(o);
            }
            else if (valinta == "k")
            {
                r = (Random)o;
                WriteLine(r);
            }
            else if (valinta == "l")
            {
                b = Convert.ToBoolean(o);
                WriteLine(b);
            }
            else
            {
                WriteLine("Ei toi luetunymmärtäminen ainakaan o sun vahvuutes.");
            }
            ReadLine();
        }
    }
}
