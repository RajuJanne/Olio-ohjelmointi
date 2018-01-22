using System;
using static System.Console;

namespace H2_Tehtava_1
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

            x = (int)y; // Long ei mene intiin ilman muunnosta
            WriteLine(x);
            y = (long)d; // y == 4
            WriteLine(y);
            d = x;
            WriteLine(d);
            x = c;
            WriteLine(x);
            s = $"{x}"; // lul?
            WriteLine(s);
            x = int.Parse(s); // string ei mene intiin ilman muunnosta
            WriteLine(x);
            b = x > y;
            WriteLine(b);
            s = $"{t}"; //
            WriteLine(s);
            o = t;
            WriteLine(o);
            o = x;
            WriteLine(o);
            r = o;
            WriteLine(r);
            b = o;
            WriteLine(b);
            ReadLine();
        }
    }
}
