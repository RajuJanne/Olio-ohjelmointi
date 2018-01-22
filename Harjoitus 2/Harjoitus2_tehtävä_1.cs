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

            string valinta = ReadLine("Anna alakohta (a-l): ");

            if (valinta == "a") {
              x = (int)y; // Long ei mene intiin ilman muunnosta
              WriteLine(x);
            }
            if (valinta == "b") {
              y = (long)d; // y == 4
              WriteLine(y);
            }
            if (valinta == "c") {
              d = x;
              WriteLine(d);
            }
            if (valinta == "d") {
              x = c;
              WriteLine(x);
            }
            if (valita == "e") {
              s = $"{x}"; // lul?
              WriteLine(s);
            }
            if (valinta == "f") {
              x = int.Parse(s); // string ei mene intiin ilman muunnosta
              WriteLine(x);
            }
            if (valinta == "g") {
              b = x > y;
              WriteLine(b);
            }
            if (valinta == "h") {
              s = $"{t}"; //
              WriteLine(s);
            }
            if (valinta == "i")
            {
              o = t;
              WriteLine(o);
            }
            if (valinta == "j") {
              o = x;
              WriteLine(o);
            }
            if (valinta == "k") {
              r = o;
              WriteLine(r);
            }
            if (valinta == "l")
            {
              b = o;
              WriteLine(b);
            }
            ReadLine();
        }
    }
}
